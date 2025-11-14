using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15011 - .
/// </summary>
public class F15011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NKDOCO.
        /// </summary>
        public const string NKDOCO = "NKDOCO";

        /// <summary>
        /// NKBCI.
        /// </summary>
        public const string NKBCI = "NKBCI";

        /// <summary>
        /// NKGENT.
        /// </summary>
        public const string NKGENT = "NKGENT";

        /// <summary>
        /// NKCTRY.
        /// </summary>
        public const string NKCTRY = "NKCTRY";

        /// <summary>
        /// NKYR.
        /// </summary>
        public const string NKYR = "NKYR";

        /// <summary>
        /// NKBF01.
        /// </summary>
        public const string NKBF01 = "NKBF01";

        /// <summary>
        /// NKBF02.
        /// </summary>
        public const string NKBF02 = "NKBF02";

        /// <summary>
        /// NKBF03.
        /// </summary>
        public const string NKBF03 = "NKBF03";

        /// <summary>
        /// NKBF04.
        /// </summary>
        public const string NKBF04 = "NKBF04";

        /// <summary>
        /// NKBF05.
        /// </summary>
        public const string NKBF05 = "NKBF05";

        /// <summary>
        /// NKBF06.
        /// </summary>
        public const string NKBF06 = "NKBF06";

        /// <summary>
        /// NKBF07.
        /// </summary>
        public const string NKBF07 = "NKBF07";

        /// <summary>
        /// NKBF08.
        /// </summary>
        public const string NKBF08 = "NKBF08";

        /// <summary>
        /// NKBF09.
        /// </summary>
        public const string NKBF09 = "NKBF09";

        /// <summary>
        /// NKBF10.
        /// </summary>
        public const string NKBF10 = "NKBF10";

        /// <summary>
        /// NKBF11.
        /// </summary>
        public const string NKBF11 = "NKBF11";

        /// <summary>
        /// NKBF12.
        /// </summary>
        public const string NKBF12 = "NKBF12";

        /// <summary>
        /// NKBF13.
        /// </summary>
        public const string NKBF13 = "NKBF13";

        /// <summary>
        /// NKUSER.
        /// </summary>
        public const string NKUSER = "NKUSER";

        /// <summary>
        /// NKUPMJ.
        /// </summary>
        public const string NKUPMJ = "NKUPMJ";

        /// <summary>
        /// NKPID.
        /// </summary>
        public const string NKPID = "NKPID";

        /// <summary>
        /// NKJOBN.
        /// </summary>
        public const string NKJOBN = "NKJOBN";

        /// <summary>
        /// NKUPMT.
        /// </summary>
        public const string NKUPMT = "NKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F15011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NKDOCO", "NKDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NKBCI", "NKBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("NKGENT", "NKGENT", JdeDataType.String, 2, true, true),
        new JdeField("NKCTRY", "NKCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("NKYR", "NKYR", JdeDataType.Numeric, null, true, true),
        new JdeField("NKBF01", "NKBF01", JdeDataType.String, 2),
        new JdeField("NKBF02", "NKBF02", JdeDataType.String, 2),
        new JdeField("NKBF03", "NKBF03", JdeDataType.String, 2),
        new JdeField("NKBF04", "NKBF04", JdeDataType.String, 2),
        new JdeField("NKBF05", "NKBF05", JdeDataType.String, 2),
        new JdeField("NKBF06", "NKBF06", JdeDataType.String, 2),
        new JdeField("NKBF07", "NKBF07", JdeDataType.String, 2),
        new JdeField("NKBF08", "NKBF08", JdeDataType.String, 2),
        new JdeField("NKBF09", "NKBF09", JdeDataType.String, 2),
        new JdeField("NKBF10", "NKBF10", JdeDataType.String, 2),
        new JdeField("NKBF11", "NKBF11", JdeDataType.String, 2),
        new JdeField("NKBF12", "NKBF12", JdeDataType.String, 2),
        new JdeField("NKBF13", "NKBF13", JdeDataType.String, 2),
        new JdeField("NKUSER", "NKUSER", JdeDataType.String, 20),
        new JdeField("NKUPMJ", "NKUPMJ", JdeDataType.Numeric),
        new JdeField("NKPID", "NKPID", JdeDataType.String, 20),
        new JdeField("NKJOBN", "NKJOBN", JdeDataType.String, 20),
        new JdeField("NKUPMT", "NKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15011_0", "Primary Key on NKDOCO, NKBCI, NKGENT, NKCTRY, NKYR", new[] { "NKDOCO", "NKBCI", "NKGENT", "NKCTRY", "NKYR" }, isUnique: true, isPrimaryKey: true)
    };
}
