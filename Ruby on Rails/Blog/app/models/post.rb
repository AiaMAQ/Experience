class Post < ApplicationRecord

 #validates_presence_of :title, :content

  validates :title, presence: true
  validates :title, length: {maximum: 100}


  def self.no_content     
            where(:content => nil)
  end

  def abstract
      self.content[0..20]
  end


end
