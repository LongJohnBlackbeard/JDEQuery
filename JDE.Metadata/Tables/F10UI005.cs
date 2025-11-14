using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10UI005 - .
/// </summary>
public class F10UI005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SROTPS.
        /// </summary>
        public const string SROTPS = "SROTPS";

        /// <summary>
        /// SROD01.
        /// </summary>
        public const string SROD01 = "SROD01";

        /// <summary>
        /// SROD02.
        /// </summary>
        public const string SROD02 = "SROD02";

        /// <summary>
        /// SROD03.
        /// </summary>
        public const string SROD03 = "SROD03";

        /// <summary>
        /// SROD04.
        /// </summary>
        public const string SROD04 = "SROD04";

        /// <summary>
        /// SROD05.
        /// </summary>
        public const string SROD05 = "SROD05";

        /// <summary>
        /// SROD06.
        /// </summary>
        public const string SROD06 = "SROD06";

        /// <summary>
        /// SROD07.
        /// </summary>
        public const string SROD07 = "SROD07";

        /// <summary>
        /// SROD08.
        /// </summary>
        public const string SROD08 = "SROD08";

        /// <summary>
        /// SROD09.
        /// </summary>
        public const string SROD09 = "SROD09";

        /// <summary>
        /// SROD10.
        /// </summary>
        public const string SROD10 = "SROD10";

        /// <summary>
        /// SROD11.
        /// </summary>
        public const string SROD11 = "SROD11";

        /// <summary>
        /// SROD12.
        /// </summary>
        public const string SROD12 = "SROD12";

        /// <summary>
        /// SROD13.
        /// </summary>
        public const string SROD13 = "SROD13";

        /// <summary>
        /// SROD14.
        /// </summary>
        public const string SROD14 = "SROD14";

        /// <summary>
        /// SROD15.
        /// </summary>
        public const string SROD15 = "SROD15";

        /// <summary>
        /// SROD16.
        /// </summary>
        public const string SROD16 = "SROD16";

        /// <summary>
        /// SROD17.
        /// </summary>
        public const string SROD17 = "SROD17";

        /// <summary>
        /// SROD18.
        /// </summary>
        public const string SROD18 = "SROD18";

        /// <summary>
        /// SROD19.
        /// </summary>
        public const string SROD19 = "SROD19";

        /// <summary>
        /// SROD20.
        /// </summary>
        public const string SROD20 = "SROD20";

        /// <summary>
        /// SRMATH01.
        /// </summary>
        public const string SRMATH01 = "SRMATH01";

        /// <summary>
        /// SRMCU.
        /// </summary>
        public const string SRMCU = "SRMCU";

        /// <summary>
        /// SRMD.
        /// </summary>
        public const string SRMD = "SRMD";

        /// <summary>
        /// SRAN8.
        /// </summary>
        public const string SRAN8 = "SRAN8";

        /// <summary>
        /// SRVC01A.
        /// </summary>
        public const string SRVC01A = "SRVC01A";

        /// <summary>
        /// SRUSER.
        /// </summary>
        public const string SRUSER = "SRUSER";

        /// <summary>
        /// SRPID.
        /// </summary>
        public const string SRPID = "SRPID";

        /// <summary>
        /// SRJOBN.
        /// </summary>
        public const string SRJOBN = "SRJOBN";

        /// <summary>
        /// SRUPMJ.
        /// </summary>
        public const string SRUPMJ = "SRUPMJ";

        /// <summary>
        /// SRUPMT.
        /// </summary>
        public const string SRUPMT = "SRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F10UI005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SROTPS", "SROTPS", JdeDataType.String, 6, true, true),
        new JdeField("SROD01", "SROD01", JdeDataType.String, 80),
        new JdeField("SROD02", "SROD02", JdeDataType.String, 80),
        new JdeField("SROD03", "SROD03", JdeDataType.String, 80),
        new JdeField("SROD04", "SROD04", JdeDataType.String, 80),
        new JdeField("SROD05", "SROD05", JdeDataType.String, 80),
        new JdeField("SROD06", "SROD06", JdeDataType.String, 80),
        new JdeField("SROD07", "SROD07", JdeDataType.String, 80),
        new JdeField("SROD08", "SROD08", JdeDataType.String, 80),
        new JdeField("SROD09", "SROD09", JdeDataType.String, 80),
        new JdeField("SROD10", "SROD10", JdeDataType.String, 80),
        new JdeField("SROD11", "SROD11", JdeDataType.String, 80),
        new JdeField("SROD12", "SROD12", JdeDataType.String, 80),
        new JdeField("SROD13", "SROD13", JdeDataType.String, 80),
        new JdeField("SROD14", "SROD14", JdeDataType.String, 80),
        new JdeField("SROD15", "SROD15", JdeDataType.String, 80),
        new JdeField("SROD16", "SROD16", JdeDataType.String, 80),
        new JdeField("SROD17", "SROD17", JdeDataType.String, 80),
        new JdeField("SROD18", "SROD18", JdeDataType.String, 80),
        new JdeField("SROD19", "SROD19", JdeDataType.String, 80),
        new JdeField("SROD20", "SROD20", JdeDataType.String, 80),
        new JdeField("SRMATH01", "SRMATH01", JdeDataType.Numeric),
        new JdeField("SRMCU", "SRMCU", JdeDataType.String, 24, true, true),
        new JdeField("SRMD", "SRMD", JdeDataType.String, 120),
        new JdeField("SRAN8", "SRAN8", JdeDataType.Numeric),
        new JdeField("SRVC01A", "SRVC01A", JdeDataType.String, 2),
        new JdeField("SRUSER", "SRUSER", JdeDataType.String, 20),
        new JdeField("SRPID", "SRPID", JdeDataType.String, 20),
        new JdeField("SRJOBN", "SRJOBN", JdeDataType.String, 20),
        new JdeField("SRUPMJ", "SRUPMJ", JdeDataType.Numeric),
        new JdeField("SRUPMT", "SRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10UI005_0", "Primary Key on SROTPS, SRMCU", new[] { "SROTPS", "SRMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
