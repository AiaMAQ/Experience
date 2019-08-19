require 'rails_helper'

RSpec.describe Project do
  it "is not valid without a title" do
    project = Project.new
    expect(project).not_to be_valid
  end
end
