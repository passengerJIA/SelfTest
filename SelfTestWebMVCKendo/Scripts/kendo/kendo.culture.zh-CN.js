kendo.cultures["zh-CN"] = {
    // <language code>-<country/region code>
    name: "zh-CN",
    // The "numberFormat" defines general number formatting rules.
    numberFormat: {
        //numberFormat has only negative pattern unlike the percent and currency
        //negative pattern: one of (n)|-n|- n|n-|n -
        pattern: ["-n"],
        //number of decimal places
        decimals: 2,
        //string that separates the number groups (1,000,000)
        ",": ",",
        // A string that separates a number from the fractional point.
        ".": ".",
        //the length of each number group
        groupSize: [3],
        //formatting rules for percent number
        percent: {
            //[negative pattern, positive pattern]
            // negativePattern: one of -n %|-n%|-%n|%-n|%n-|n-%|n%-|-% n|n %-|% n-|% -n|n- %
            //positivePattern: one of n %|n%|%n|% n
            pattern: ["-n %", "n %"],
            // The number of decimal places.
            decimals: 2,
            // The string that separates the number groups (1,000,000 %).
            ",": ",",
            // The string that separates a number from the fractional point.
            ".": ".",
            // The length of each number group.
            groupSize: [3],
            //percent symbol
            symbol: "%"
        },
        currency: {
            // [negative pattern, positive pattern]
            // negativePattern: one of "($n)|-$n|$-n|$n-|(n$)|-n$|n-$|n$-|-n $|-$ n|n $-|$ n-|$ -n|n- $|($ n)|(n $)"
            //positivePattern: one of "$n|n$|$ n|n $"
            pattern: ["($n)", "$n"],
            // The number of decimal places.
            decimals: 2,
            // The string that separates the number groups (1,000,000 $).
            ",": ",",
            // The string that separates a number from the fractional point.
            ".": ".",
            // The length of each number group.
            groupSize: [3],
            // The currency symbol.
            symbol: "$"
        }
    },
    calendars: {
        standard: {
            days: {
                // The full day names.
                names: ["星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六"],
                // The abbreviated day names.
                namesAbbr: ["周日", "周一", "周二", "周三", "周四", "周五", "周六"],
                // The shortest day names.
                namesShort: ["周日", "周一", "周二", "周三", "周四", "周五", "周六"]
            },
            months: {
                // The full month names.
                names: ["一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"],
                // abbreviated month names
                namesAbbr: ["一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"]
            },
            // The AM and PM designators.
            // [standard,lowercase,uppercase]
            AM: ["AM", "am", "AM"],
            PM: ["PM", "pm", "PM"],
            // The set of predefined date and time patterns used by the culture.
            patterns: {
                d: "M/d/yyyy",
                D: "dddd, MMMM dd, yyyy",
                F: "dddd, MMMM dd, yyyy h:mm:ss tt",
                g: "M/d/yyyy h:mm tt",
                G: "M/d/yyyy h:mm:ss tt",
                m: "MMMM dd",
                M: "MMMM dd",
                s: "yyyy'-'MM'-'ddTHH':'mm':'ss",
                t: "h:mm tt",
                T: "h:mm:ss tt",
                u: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
                y: "MMMM, yyyy",
                Y: "MMMM, yyyy"
            },
            // The first day of the week (0 = Sunday, 1 = Monday, and so on).
            firstDay: 1
        }
    }
};