using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_calculator
{
    public partial class Form1 : Form
    {
        private bool is_act;
        private bool is_fractal;
        private float preserved_num;
        public Form1()
        {
            InitializeComponent();
     
        }

        private void add_num_to_list(string str, ref int pos, ref List<string> reverse_polish_not)
        {
            string num = "";
            num += str[pos];
            pos++;
            while ((pos != str.Length) && ((str[pos] >= '0' && str[pos] <= '9') || (str[pos] == ',')) )
            {
                num += str[pos];
                pos++;
            }
            reverse_polish_not.Add(num);
            pos--;
        }
        private void point_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (output_pane.Text.Length > 0 && is_fractal == false)
            {
                if (output_pane.Text.EndsWith("+") || output_pane.Text.EndsWith("-") || output_pane.Text.EndsWith("*")
                                    || output_pane.Text.EndsWith("/"))
               
                {
                    return;
                }
                is_fractal = true;
                output_pane.Text += ',';
            }
        }



        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            output_pane.Text = "";
            is_fractal = false;
            is_act = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/" )
            {
                is_fractal = false;
                
                if (is_act == true || (!output_pane.Text.Any() && btn.Text != "-"))
                {
                    return;
                }
                else
                {
                    is_act = true;
                }
            } else
            {
                is_act = false;
            }
            if ((btn.Text == "(") && (!output_pane.Text.EndsWith("+") && !output_pane.Text.EndsWith("-")&& !output_pane.Text.EndsWith("*")
                                    && !output_pane.Text.EndsWith("/") && !output_pane.Text.EndsWith("(")
                                    && output_pane.Text.Any()))
            {
                return;
            }
            if (btn.Text == ")" && (output_pane.Text.EndsWith("+") || output_pane.Text.EndsWith("-") || output_pane.Text.EndsWith("*")
                                    || output_pane.Text.EndsWith("/")))
            {
                return;
            }    
                output_pane.Text += btn.Text;

        }

  

        private float calc_RPN_expression(ref List<string> rev_polish_notation)
        {
            Stack<float> num_stack = new Stack<float>();
            foreach (var item in rev_polish_notation)
            {
                if (item == "+" || item == "-"
                    || item == "*" || item == "/")
                {
                    float temp1 = num_stack.Pop();
                    float temp2 = num_stack.Pop();
                    float res = 0;
                    if (item == "+")
                    {
                        res = temp2 + temp1;
                    }
                    else if (item == "-")
                    {
                        res = temp2 - temp1;
                    }
                    else if (item == "*")
                    {
                        res = temp2 * temp1;
                    }
                    else if (item == "/")
                    {
                        if (temp1 == 0)
                        {
                            MessageBox.Show("Деление на 0 невозможно", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                        res = temp2 / temp1;
                    }
                    num_stack.Push(res);
                }
                else
                {
                    num_stack.Push(Convert.ToSingle(item));
                }
            }
            return num_stack.Peek();
        }

        private int check_priority(char sign)
        {
            if (sign == '(') return 0;
            if (sign == '+' || sign == '-') return 1;
            if (sign == '*' || sign == '/') return 2;
            return 3;
        }

        bool is_expr_correct(string str)
        {
            int br_balance = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    br_balance++;
                }
                if (str[i] == ')')
                {
                    br_balance--;
                }
            }
            if (br_balance != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void calc_Click(object sender, EventArgs e)
        {
            List<string> rev_polish_notation = new List<string>();
            Stack<char> oper_signs = new Stack<char>();
            string src_str = output_pane.Text;
            if (!src_str.Any())
            {
                return;
            }
            if (src_str.EndsWith("+") || src_str.EndsWith("-") ||
                        src_str.EndsWith("*") || src_str.EndsWith("/"))
            {
                MessageBox.Show("недопустимый формат выражения", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button_clear_Click(sender, e);
                return;
            }
            if (!is_expr_correct(src_str))
            {
                MessageBox.Show("Недопустимое соотношение скобок", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button_clear_Click(sender, e);
                return;
            }

            for (int i = 0; i < src_str.Length; i++)
            {
                if ((src_str[i] >= '0' && src_str[i] <= '9') || 
                                    (src_str[i] == '-' && (i == 0 || src_str[i - 1] == '(')))
                {
                    add_num_to_list(src_str, ref i, ref rev_polish_notation);
                    continue;
                }
                if (src_str[i] == '+' || src_str[i] == '-' || src_str[i] == '*'
                        || src_str[i] == '/' )
                {
                    while ((oper_signs.Any()) &&  (check_priority(oper_signs.Peek()) >= check_priority(src_str[i])))
                    {
                        rev_polish_notation.Add(oper_signs.Pop().ToString());
                    }
                    oper_signs.Push(src_str[i]);
                }

                if (src_str[i] == '(')
                {
                    oper_signs.Push(src_str[i]);
                }
                if (src_str[i] == ')')
                {
                    while (oper_signs.Peek() != '(')
                    {
                        rev_polish_notation.Add(oper_signs.Pop().ToString());
                    }
                    oper_signs.Pop();
                }
            }
            while (oper_signs.Any())
            {
                rev_polish_notation.Add(oper_signs.Pop().ToString());
            }

            float res = calc_RPN_expression(ref rev_polish_notation);
            output_pane.Text = res.ToString();

            if (output_pane.Text.Contains(","))
            {
                is_fractal = true;
            }
            else
            {
                is_fractal = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (output_pane.Text.Any())
            {
                char symb = output_pane.Text[output_pane.Text.Length - 1];
                output_pane.Text = output_pane.Text.Substring(0, output_pane.Text.Length - 1);
                if (symb == ',')
                {
                    is_fractal = false;
                    
                }
                if (symb == '+' || symb == '-' || symb == '*' || symb == '/')
                {
                    is_act = false;
                } else if (output_pane.Text.EndsWith("+") || output_pane.Text.EndsWith("-") 
                    || output_pane.Text.EndsWith("/") || output_pane.Text.EndsWith("*"))
                {
                    is_act = true;
                }
            }
        }

        private void mem_save_Click(object sender, EventArgs e)
        {
            float number = 0;
            if (float.TryParse(output_pane.Text, out number))
            {
                preserved_num = number;
            } else
            {
                MessageBox.Show("Невозможно сохранить выражение в память", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mem_read_Click(object sender, EventArgs e)
        {
            output_pane.Text = preserved_num.ToString();
            is_act = false;
            if (output_pane.Text.Contains(","))
            {
                is_fractal = true;
            } else
            {
                is_fractal = false;
            }
        }

        private void mem_plus_Click(object sender, EventArgs e)
        {
            float number = 0;
            if (float.TryParse(output_pane.Text, out number))
            {
                preserved_num += number;
            }
            else
            {
                MessageBox.Show("Невозможно сохранить выражение в память", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mem_minus_Click(object sender, EventArgs e)
        {
            float number = 0;
            if (float.TryParse(output_pane.Text, out number))
            {
                preserved_num -= number;
            }
            else
            {
                MessageBox.Show("Невозможно сохранить выражение в память", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
