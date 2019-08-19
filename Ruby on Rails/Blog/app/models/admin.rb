class Admin < ApplicationRecord
  has_many :projects
  has_many :posts
  has_many :users
  # Include default devise modules. Others available are:
  # :confirmable, :lockable, :timeoutable, :trackable and :omniauthable
  devise :database_authenticatable, :trackable, :timeoutable
end
