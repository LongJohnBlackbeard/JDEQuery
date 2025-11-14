using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F078507 - .
/// </summary>
public class F078507 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YEAN8.
        /// </summary>
        public const string YEAN8 = "YEAN8";

        /// <summary>
        /// YEDATE01.
        /// </summary>
        public const string YEDATE01 = "YEDATE01";

        /// <summary>
        /// YEEV01.
        /// </summary>
        public const string YEEV01 = "YEEV01";

        /// <summary>
        /// YEFTC.
        /// </summary>
        public const string YEFTC = "YEFTC";

        /// <summary>
        /// YEP01.
        /// </summary>
        public const string YEP01 = "YEP01";

        /// <summary>
        /// YEP02.
        /// </summary>
        public const string YEP02 = "YEP02";

        /// <summary>
        /// YEP03.
        /// </summary>
        public const string YEP03 = "YEP03";

        /// <summary>
        /// YEP04.
        /// </summary>
        public const string YEP04 = "YEP04";

        /// <summary>
        /// YEP05.
        /// </summary>
        public const string YEP05 = "YEP05";

        /// <summary>
        /// YEADPLOCMI.
        /// </summary>
        public const string YEADPLOCMI = "YEADPLOCMI";

        /// <summary>
        /// YEADPLOCMN.
        /// </summary>
        public const string YEADPLOCMN = "YEADPLOCMN";

        /// <summary>
        /// YEADPMISC1.
        /// </summary>
        public const string YEADPMISC1 = "YEADPMISC1";

        /// <summary>
        /// YEADPMISC2.
        /// </summary>
        public const string YEADPMISC2 = "YEADPMISC2";

        /// <summary>
        /// YEADPMISC3.
        /// </summary>
        public const string YEADPMISC3 = "YEADPMISC3";

        /// <summary>
        /// YEADPMISC4.
        /// </summary>
        public const string YEADPMISC4 = "YEADPMISC4";

        /// <summary>
        /// YEADPMISC5.
        /// </summary>
        public const string YEADPMISC5 = "YEADPMISC5";

        /// <summary>
        /// YEADPMISC6.
        /// </summary>
        public const string YEADPMISC6 = "YEADPMISC6";

        /// <summary>
        /// YEADPMISC7.
        /// </summary>
        public const string YEADPMISC7 = "YEADPMISC7";

        /// <summary>
        /// YEADPMISC8.
        /// </summary>
        public const string YEADPMISC8 = "YEADPMISC8";

        /// <summary>
        /// YEADPMISC9.
        /// </summary>
        public const string YEADPMISC9 = "YEADPMISC9";

        /// <summary>
        /// YEADPMISC0.
        /// </summary>
        public const string YEADPMISC0 = "YEADPMISC0";
    }

    /// <inheritdoc />
    public override string TableName => "F078507";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YEAN8", "YEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YEDATE01", "YEDATE01", JdeDataType.Numeric),
        new JdeField("YEEV01", "YEEV01", JdeDataType.String, 2),
        new JdeField("YEFTC", "YEFTC", JdeDataType.String, 10),
        new JdeField("YEP01", "YEP01", JdeDataType.String, 6),
        new JdeField("YEP02", "YEP02", JdeDataType.String, 6),
        new JdeField("YEP03", "YEP03", JdeDataType.String, 6),
        new JdeField("YEP04", "YEP04", JdeDataType.String, 6),
        new JdeField("YEP05", "YEP05", JdeDataType.String, 6),
        new JdeField("YEADPLOCMI", "YEADPLOCMI", JdeDataType.String, 12),
        new JdeField("YEADPLOCMN", "YEADPLOCMN", JdeDataType.String, 12),
        new JdeField("YEADPMISC1", "YEADPMISC1", JdeDataType.String, 40),
        new JdeField("YEADPMISC2", "YEADPMISC2", JdeDataType.String, 40),
        new JdeField("YEADPMISC3", "YEADPMISC3", JdeDataType.String, 40),
        new JdeField("YEADPMISC4", "YEADPMISC4", JdeDataType.String, 40),
        new JdeField("YEADPMISC5", "YEADPMISC5", JdeDataType.String, 40),
        new JdeField("YEADPMISC6", "YEADPMISC6", JdeDataType.String, 40),
        new JdeField("YEADPMISC7", "YEADPMISC7", JdeDataType.String, 40),
        new JdeField("YEADPMISC8", "YEADPMISC8", JdeDataType.String, 40),
        new JdeField("YEADPMISC9", "YEADPMISC9", JdeDataType.String, 40),
        new JdeField("YEADPMISC0", "YEADPMISC0", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F078507_0", "Primary Key on YEAN8", new[] { "YEAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
