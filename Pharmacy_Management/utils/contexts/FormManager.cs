using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pharmacy_Management.utils.contexts
{
    public static class FormManager
    {
        private static Dictionary<string, Form> forms = new Dictionary<string, Form>();
        private static Stack<Form> previousForms = new Stack<Form>();

        public static void RegisterForm(string name, Form form)
        {
            if (forms.ContainsKey(name))
            {
                forms[name] = form;
                Console.WriteLine(forms);
            }
            else
            {
                forms.Add(name, form);
                Console.WriteLine(forms);
            }
        }

        public static void NavigateTo(string formName)
        {
            if (forms.ContainsKey(formName))
            {
                Form form = forms[formName];
                if (previousForms.Count > 0)
                {
                    Form previousForm = previousForms.Peek();
                    previousForm.Hide();
                }

                previousForms.Push(form);
                form.Show();
                Console.WriteLine(forms);

            }
            else
            {
                MessageBox.Show("Form not found: " + formName);
                Application.Exit();
            }
        }

        public static void GoBack()
        {
            if (previousForms.Count > 1)
            {
                Form currentForm = previousForms.Pop();
                currentForm.Hide();
                Form previousForm = previousForms.Peek();
                previousForm.Show();
            }
            else if (previousForms.Count == 1)
            {
                DialogResult exitDialog = MessageBox.Show("This is the last item in the forms stack... Are you sure you want to close", "Close", MessageBoxButtons.YesNo);
                if (exitDialog == DialogResult.Yes)
                {
                    Form currentForm = previousForms.Pop();
                    currentForm.Hide();
                    MessageBox.Show("No previous form to navigate back to.");
                    Application.Exit();
                    //currentForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Stack was already empty. Application will exit...");
                Application.Exit();
            }
        }
    }
}
