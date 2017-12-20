using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda
{
    public partial class AsyncLambdas : Form
    {
        public AsyncLambdas()
        {
            InitializeComponent();

            btnAs.Click += async (sender, e) =>
            {
                // ExampleMethodAsync returns a Task.  
                await ExampleMethodAsync();
                textBox1.Text += "\n Click  Async Lambda event handler.\n";
            };
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // ExampleMethodAsync returns a Task.  
            await ExampleMethodAsync();
            textBox2.Text += "\r\n Click Async event handler.\n";
        }

        async Task ExampleMethodAsync()
        {
            // The following line simulates a task-returning asynchronous process.  
            await Task.Delay(1000);
        }
    }
}

/*     Async Lambdas
You can easily create lambda expressions and statements that incorporate asynchronous processing by using the async and await keywords. For example, the following Windows Forms example contains an event handler that calls and awaits an async method, ExampleMethodAsync.
 */
