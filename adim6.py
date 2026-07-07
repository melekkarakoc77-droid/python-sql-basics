def calculate_match(score):
    if score >=80 :
        return "great match this job"
    else :
        return "you need to learn more skills"
user_score =int(input("enter your cv match score:"))
match_result = calculate_match(user_score)
print(f"result :{match_result}")