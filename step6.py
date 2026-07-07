def check_intership(months):
    if months == 0 :
        return "you should apply for a junior position"
    elif months >=1 and months <=12 :
        return "you are ready for data associate position"
    else :
        return"wow you have perfect experience"
experience_input = int(input("how many months of experience do you have :"))
job_recommendation = check_intership(experience_input)
print(f"recommendation : {job_recommendation}")