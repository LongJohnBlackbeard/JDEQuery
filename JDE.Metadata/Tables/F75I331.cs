using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I331 - .
/// </summary>
public class F75I331 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AIAN8.
        /// </summary>
        public const string AIAN8 = "AIAN8";

        /// <summary>
        /// AICO.
        /// </summary>
        public const string AICO = "AICO";

        /// <summary>
        /// AII75AC01.
        /// </summary>
        public const string AII75AC01 = "AII75AC01";

        /// <summary>
        /// AII75AC02.
        /// </summary>
        public const string AII75AC02 = "AII75AC02";

        /// <summary>
        /// AII75AC03.
        /// </summary>
        public const string AII75AC03 = "AII75AC03";

        /// <summary>
        /// AII75AC04.
        /// </summary>
        public const string AII75AC04 = "AII75AC04";

        /// <summary>
        /// AII75AC05.
        /// </summary>
        public const string AII75AC05 = "AII75AC05";

        /// <summary>
        /// AII75AC06.
        /// </summary>
        public const string AII75AC06 = "AII75AC06";

        /// <summary>
        /// AII75AC07.
        /// </summary>
        public const string AII75AC07 = "AII75AC07";

        /// <summary>
        /// AII75AC08.
        /// </summary>
        public const string AII75AC08 = "AII75AC08";

        /// <summary>
        /// AII75AC09.
        /// </summary>
        public const string AII75AC09 = "AII75AC09";

        /// <summary>
        /// AII75AC10.
        /// </summary>
        public const string AII75AC10 = "AII75AC10";

        /// <summary>
        /// AII75AC11.
        /// </summary>
        public const string AII75AC11 = "AII75AC11";

        /// <summary>
        /// AII75AC12.
        /// </summary>
        public const string AII75AC12 = "AII75AC12";

        /// <summary>
        /// AII75AC13.
        /// </summary>
        public const string AII75AC13 = "AII75AC13";

        /// <summary>
        /// AII75AC14.
        /// </summary>
        public const string AII75AC14 = "AII75AC14";

        /// <summary>
        /// AII75AC15.
        /// </summary>
        public const string AII75AC15 = "AII75AC15";

        /// <summary>
        /// AII75AC16.
        /// </summary>
        public const string AII75AC16 = "AII75AC16";

        /// <summary>
        /// AII75AC17.
        /// </summary>
        public const string AII75AC17 = "AII75AC17";

        /// <summary>
        /// AII75AC18.
        /// </summary>
        public const string AII75AC18 = "AII75AC18";

        /// <summary>
        /// AII75AC19.
        /// </summary>
        public const string AII75AC19 = "AII75AC19";

        /// <summary>
        /// AII75AC20.
        /// </summary>
        public const string AII75AC20 = "AII75AC20";

        /// <summary>
        /// AII75AC21.
        /// </summary>
        public const string AII75AC21 = "AII75AC21";

        /// <summary>
        /// AII75AC22.
        /// </summary>
        public const string AII75AC22 = "AII75AC22";

        /// <summary>
        /// AII75AC23.
        /// </summary>
        public const string AII75AC23 = "AII75AC23";

        /// <summary>
        /// AII75AC24.
        /// </summary>
        public const string AII75AC24 = "AII75AC24";

        /// <summary>
        /// AII75AC25.
        /// </summary>
        public const string AII75AC25 = "AII75AC25";

        /// <summary>
        /// AII75AC26.
        /// </summary>
        public const string AII75AC26 = "AII75AC26";

        /// <summary>
        /// AII75AC27.
        /// </summary>
        public const string AII75AC27 = "AII75AC27";

        /// <summary>
        /// AII75AC28.
        /// </summary>
        public const string AII75AC28 = "AII75AC28";

        /// <summary>
        /// AII75AC29.
        /// </summary>
        public const string AII75AC29 = "AII75AC29";

        /// <summary>
        /// AII75AC30.
        /// </summary>
        public const string AII75AC30 = "AII75AC30";

        /// <summary>
        /// AIUSER.
        /// </summary>
        public const string AIUSER = "AIUSER";

        /// <summary>
        /// AIPID.
        /// </summary>
        public const string AIPID = "AIPID";

        /// <summary>
        /// AIJOBN.
        /// </summary>
        public const string AIJOBN = "AIJOBN";

        /// <summary>
        /// AIUPMJ.
        /// </summary>
        public const string AIUPMJ = "AIUPMJ";

        /// <summary>
        /// AIUPMT.
        /// </summary>
        public const string AIUPMT = "AIUPMT";

        /// <summary>
        /// AII75EXCAT.
        /// </summary>
        public const string AII75EXCAT = "AII75EXCAT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I331";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AIAN8", "AIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AICO", "AICO", JdeDataType.String, 10, true, true),
        new JdeField("AII75AC01", "AII75AC01", JdeDataType.String, 6),
        new JdeField("AII75AC02", "AII75AC02", JdeDataType.String, 6),
        new JdeField("AII75AC03", "AII75AC03", JdeDataType.String, 6),
        new JdeField("AII75AC04", "AII75AC04", JdeDataType.String, 6),
        new JdeField("AII75AC05", "AII75AC05", JdeDataType.String, 6),
        new JdeField("AII75AC06", "AII75AC06", JdeDataType.String, 6),
        new JdeField("AII75AC07", "AII75AC07", JdeDataType.String, 6),
        new JdeField("AII75AC08", "AII75AC08", JdeDataType.String, 6),
        new JdeField("AII75AC09", "AII75AC09", JdeDataType.String, 6),
        new JdeField("AII75AC10", "AII75AC10", JdeDataType.String, 6),
        new JdeField("AII75AC11", "AII75AC11", JdeDataType.String, 6),
        new JdeField("AII75AC12", "AII75AC12", JdeDataType.String, 6),
        new JdeField("AII75AC13", "AII75AC13", JdeDataType.String, 6),
        new JdeField("AII75AC14", "AII75AC14", JdeDataType.String, 6),
        new JdeField("AII75AC15", "AII75AC15", JdeDataType.String, 6),
        new JdeField("AII75AC16", "AII75AC16", JdeDataType.String, 6),
        new JdeField("AII75AC17", "AII75AC17", JdeDataType.String, 6),
        new JdeField("AII75AC18", "AII75AC18", JdeDataType.String, 6),
        new JdeField("AII75AC19", "AII75AC19", JdeDataType.String, 6),
        new JdeField("AII75AC20", "AII75AC20", JdeDataType.String, 6),
        new JdeField("AII75AC21", "AII75AC21", JdeDataType.String, 6),
        new JdeField("AII75AC22", "AII75AC22", JdeDataType.String, 6),
        new JdeField("AII75AC23", "AII75AC23", JdeDataType.String, 6),
        new JdeField("AII75AC24", "AII75AC24", JdeDataType.String, 6),
        new JdeField("AII75AC25", "AII75AC25", JdeDataType.String, 6),
        new JdeField("AII75AC26", "AII75AC26", JdeDataType.String, 6),
        new JdeField("AII75AC27", "AII75AC27", JdeDataType.String, 6),
        new JdeField("AII75AC28", "AII75AC28", JdeDataType.String, 6),
        new JdeField("AII75AC29", "AII75AC29", JdeDataType.String, 6),
        new JdeField("AII75AC30", "AII75AC30", JdeDataType.String, 6),
        new JdeField("AIUSER", "AIUSER", JdeDataType.String, 20),
        new JdeField("AIPID", "AIPID", JdeDataType.String, 20),
        new JdeField("AIJOBN", "AIJOBN", JdeDataType.String, 20),
        new JdeField("AIUPMJ", "AIUPMJ", JdeDataType.Numeric),
        new JdeField("AIUPMT", "AIUPMT", JdeDataType.Numeric),
        new JdeField("AII75EXCAT", "AII75EXCAT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I331_0", "Primary Key on AIAN8, AICO", new[] { "AIAN8", "AICO" }, isUnique: true, isPrimaryKey: true)
    };
}
