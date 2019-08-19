class Contact < MailForm::Base

attribute :name,     :validate => true
  attribute :email,    :validate => /\A([\w\.%\+\-]+)@([\w]{2,})\z/i
  attribute :message,     :attachment => true
attribute :nickname, :captcha => true

def headers
 {
  :subject => "Contact Form",
  :to => "pro@test.com",
  :from => %("#{name}" <#{email}>)
 }
end

end
