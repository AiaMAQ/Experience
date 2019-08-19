require 'rails_helper'
#require 'spec_helper'

RSpec.describe PostsController, type: :controller do 

  render_views

  before do 
    @user = create(:user)
    @request.env["devise.mapping"] = Devise.mappings[:user]
  end

  describe 'Logged in' do

    before :each do
      sign_in @user
    end

    it "#index" do 
      get :index
      expect(response).to have_http_status(200)
      expect(response). to render_template(:index)
    end

    it "#new" do
      get :new
      expect(response).to have_http_status(200)
      expect(response). to render_template(:new)

    end

    it "#edit" do 
      get :edit, :post_id => post.to_param, :post => attributes_for(:post)
      expect(response).to have_http_status(200)
      expect(response). to render_template(:new)
    end
  end
  
end








