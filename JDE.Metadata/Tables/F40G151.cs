using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G151 - .
/// </summary>
public class F40G151 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QLVARID.
        /// </summary>
        public const string QLVARID = "QLVARID";

        /// <summary>
        /// QLGDISTR.
        /// </summary>
        public const string QLGDISTR = "QLGDISTR";

        /// <summary>
        /// QLTSTRSNM.
        /// </summary>
        public const string QLTSTRSNM = "QLTSTRSNM";

        /// <summary>
        /// QLAMIN.
        /// </summary>
        public const string QLAMIN = "QLAMIN";

        /// <summary>
        /// QLAMAX.
        /// </summary>
        public const string QLAMAX = "QLAMAX";

        /// <summary>
        /// QLALQTRG.
        /// </summary>
        public const string QLALQTRG = "QLALQTRG";

        /// <summary>
        /// QLALMIN.
        /// </summary>
        public const string QLALMIN = "QLALMIN";

        /// <summary>
        /// QLALMAX.
        /// </summary>
        public const string QLALMAX = "QLALMAX";

        /// <summary>
        /// QLCDEC2.
        /// </summary>
        public const string QLCDEC2 = "QLCDEC2";

        /// <summary>
        /// QLNUMT3.
        /// </summary>
        public const string QLNUMT3 = "QLNUMT3";

        /// <summary>
        /// QLSY.
        /// </summary>
        public const string QLSY = "QLSY";

        /// <summary>
        /// QLRT.
        /// </summary>
        public const string QLRT = "QLRT";

        /// <summary>
        /// QLURCD.
        /// </summary>
        public const string QLURCD = "QLURCD";

        /// <summary>
        /// QLURDT.
        /// </summary>
        public const string QLURDT = "QLURDT";

        /// <summary>
        /// QLURRF.
        /// </summary>
        public const string QLURRF = "QLURRF";

        /// <summary>
        /// QLURAT.
        /// </summary>
        public const string QLURAT = "QLURAT";

        /// <summary>
        /// QLURAB.
        /// </summary>
        public const string QLURAB = "QLURAB";

        /// <summary>
        /// QLPID.
        /// </summary>
        public const string QLPID = "QLPID";

        /// <summary>
        /// QLTORG.
        /// </summary>
        public const string QLTORG = "QLTORG";

        /// <summary>
        /// QLUSER.
        /// </summary>
        public const string QLUSER = "QLUSER";

        /// <summary>
        /// QLMKEY.
        /// </summary>
        public const string QLMKEY = "QLMKEY";

        /// <summary>
        /// QLUUPMJ.
        /// </summary>
        public const string QLUUPMJ = "QLUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G151";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QLVARID", "QLVARID", JdeDataType.Numeric, null, true, true),
        new JdeField("QLGDISTR", "QLGDISTR", JdeDataType.String, 20, true, true),
        new JdeField("QLTSTRSNM", "QLTSTRSNM", JdeDataType.String, 60, true, true),
        new JdeField("QLAMIN", "QLAMIN", JdeDataType.String, 30),
        new JdeField("QLAMAX", "QLAMAX", JdeDataType.String, 30),
        new JdeField("QLALQTRG", "QLALQTRG", JdeDataType.String, 30),
        new JdeField("QLALMIN", "QLALMIN", JdeDataType.String, 30),
        new JdeField("QLALMAX", "QLALMAX", JdeDataType.String, 30),
        new JdeField("QLCDEC2", "QLCDEC2", JdeDataType.String, 2),
        new JdeField("QLNUMT3", "QLNUMT3", JdeDataType.String, 2),
        new JdeField("QLSY", "QLSY", JdeDataType.String, 8),
        new JdeField("QLRT", "QLRT", JdeDataType.String, 4),
        new JdeField("QLURCD", "QLURCD", JdeDataType.String, 4),
        new JdeField("QLURDT", "QLURDT", JdeDataType.Numeric),
        new JdeField("QLURRF", "QLURRF", JdeDataType.String, 30),
        new JdeField("QLURAT", "QLURAT", JdeDataType.Numeric),
        new JdeField("QLURAB", "QLURAB", JdeDataType.Numeric),
        new JdeField("QLPID", "QLPID", JdeDataType.String, 20),
        new JdeField("QLTORG", "QLTORG", JdeDataType.String, 20),
        new JdeField("QLUSER", "QLUSER", JdeDataType.String, 20),
        new JdeField("QLMKEY", "QLMKEY", JdeDataType.String, 30),
        new JdeField("QLUUPMJ", "QLUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G151_0", "Primary Key on QLVARID, QLGDISTR, QLTSTRSNM", new[] { "QLVARID", "QLGDISTR", "QLTSTRSNM" }, isUnique: true, isPrimaryKey: true)
    };
}
