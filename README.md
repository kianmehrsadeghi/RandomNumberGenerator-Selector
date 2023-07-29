# RandomNumberGenerator-Selector
Code:

var NumberChars = "0123456789"; // تعیین اعداد قابل استفاده در پسورد های ساخته شده
            var random = new Random(); // متود رندوم برای اعداد شانسی در پسورد
            List<char> passwords = new List<char>(); // لیست password
            List<string> p = new List<string>(); // لیست p
            for (int h = 0; h < textBox1.Text.Length; h++) // به تعدادی که کاربر وارد میکنه کد ساخت و ذخیره پسورد تکرار شه
            {
                for (int i = 0; i < 8; i++) // حلقه ساخت هر پسورد که تعیین میکنه باید 8 کاراکتر باشن
                {
                    passwords[i] = NumberChars[random.Next(NumberChars.Length)]; // کد ساخت پسورد شانسی که با متود رندوم هر کاراکتر لیست پسورد رو تعیین میکنه تا یه پسورد شانسی 8 رقمی ایجاد شه (ارور اینجاست)
                }
            p.Add(passwords.ToString()); // لیست پسورد رو هربار به استرینگ تبدیل میکنه و وارد لیست پی میکنه
                MessageBox.Show(p[0]); // باید بیرون حلقه قرار بگیره
                MessageBox.Show(p[1]); // باید بیرون حلقه قرار بگیره
            }
