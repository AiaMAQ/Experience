ENV['RAILS_ENV'] ||= 'test'
require_relative '../config/environment'
require 'rails/test_help'

class ActiveSupport::TestCase
  # Setup all fixtures in test/fixtures/*.yml for all tests in alphabetical order.
  
  fixtures :all

  user = build(:user)

 
  user = create(:user)

  
  attrs = attributes_for(:user)

  
  stub = build_stubbed(:user)

  
  create(:user) do |user|
    user.posts.create(attributes_for(:post))
  end

end

  # Add more helper methods to be used by all tests here...
end
