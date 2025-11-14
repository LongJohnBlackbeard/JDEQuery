using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3412 - .
/// </summary>
public class F3412 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MWITM.
        /// </summary>
        public const string MWITM = "MWITM";

        /// <summary>
        /// MWMCU.
        /// </summary>
        public const string MWMCU = "MWMCU";

        /// <summary>
        /// MWDRQJ.
        /// </summary>
        public const string MWDRQJ = "MWDRQJ";

        /// <summary>
        /// MWLOVD.
        /// </summary>
        public const string MWLOVD = "MWLOVD";

        /// <summary>
        /// MWKIT.
        /// </summary>
        public const string MWKIT = "MWKIT";

        /// <summary>
        /// MWMMCU.
        /// </summary>
        public const string MWMMCU = "MWMMCU";

        /// <summary>
        /// MWUORG.
        /// </summary>
        public const string MWUORG = "MWUORG";

        /// <summary>
        /// MWDOCO.
        /// </summary>
        public const string MWDOCO = "MWDOCO";

        /// <summary>
        /// MWDCTO.
        /// </summary>
        public const string MWDCTO = "MWDCTO";

        /// <summary>
        /// MWRKCO.
        /// </summary>
        public const string MWRKCO = "MWRKCO";

        /// <summary>
        /// MWRORN.
        /// </summary>
        public const string MWRORN = "MWRORN";

        /// <summary>
        /// MWRCTO.
        /// </summary>
        public const string MWRCTO = "MWRCTO";

        /// <summary>
        /// MWRLLN.
        /// </summary>
        public const string MWRLLN = "MWRLLN";

        /// <summary>
        /// MWUKID.
        /// </summary>
        public const string MWUKID = "MWUKID";

        /// <summary>
        /// MWPLNK.
        /// </summary>
        public const string MWPLNK = "MWPLNK";

        /// <summary>
        /// MWPRJM.
        /// </summary>
        public const string MWPRJM = "MWPRJM";

        /// <summary>
        /// MWSRDM.
        /// </summary>
        public const string MWSRDM = "MWSRDM";

        /// <summary>
        /// MWPNS.
        /// </summary>
        public const string MWPNS = "MWPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F3412";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MWITM", "MWITM", JdeDataType.Numeric),
        new JdeField("MWMCU", "MWMCU", JdeDataType.String, 24),
        new JdeField("MWDRQJ", "MWDRQJ", JdeDataType.Numeric),
        new JdeField("MWLOVD", "MWLOVD", JdeDataType.Numeric),
        new JdeField("MWKIT", "MWKIT", JdeDataType.Numeric),
        new JdeField("MWMMCU", "MWMMCU", JdeDataType.String, 24),
        new JdeField("MWUORG", "MWUORG", JdeDataType.Numeric),
        new JdeField("MWDOCO", "MWDOCO", JdeDataType.Numeric),
        new JdeField("MWDCTO", "MWDCTO", JdeDataType.String, 4),
        new JdeField("MWRKCO", "MWRKCO", JdeDataType.String, 10),
        new JdeField("MWRORN", "MWRORN", JdeDataType.String, 16),
        new JdeField("MWRCTO", "MWRCTO", JdeDataType.String, 4),
        new JdeField("MWRLLN", "MWRLLN", JdeDataType.Numeric),
        new JdeField("MWUKID", "MWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("MWPLNK", "MWPLNK", JdeDataType.Numeric),
        new JdeField("MWPRJM", "MWPRJM", JdeDataType.Numeric),
        new JdeField("MWSRDM", "MWSRDM", JdeDataType.Numeric),
        new JdeField("MWPNS", "MWPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3412_0", "Primary Key on MWUKID", new[] { "MWUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3412_1", "Index on MWITM, MWMCU, MWDRQJ", new[] { "MWITM", "MWMCU", "MWDRQJ" }),
        new JdeIndex("F3412_2", "Index on MWITM, MWMCU, MWKIT, MWMMCU", new[] { "MWITM", "MWMCU", "MWKIT", "MWMMCU" }),
        new JdeIndex("F3412_3", "Index on MWKIT, MWMMCU", new[] { "MWKIT", "MWMMCU" }),
        new JdeIndex("F3412_4", "Index on MWDOCO", new[] { "MWDOCO" }),
        new JdeIndex("F3412_6", "Index on MWPLNK", new[] { "MWPLNK" }),
        new JdeIndex("F3412_7", "Index on MWMMCU", new[] { "MWMMCU" })
    };
}
