using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3430 - .
/// </summary>
public class F3430 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MVITM.
        /// </summary>
        public const string MVITM = "MVITM";

        /// <summary>
        /// MVMCU.
        /// </summary>
        public const string MVMCU = "MVMCU";

        /// <summary>
        /// MVKCOO.
        /// </summary>
        public const string MVKCOO = "MVKCOO";

        /// <summary>
        /// MVDOCO.
        /// </summary>
        public const string MVDOCO = "MVDOCO";

        /// <summary>
        /// MVDCTO.
        /// </summary>
        public const string MVDCTO = "MVDCTO";

        /// <summary>
        /// MVSFXO.
        /// </summary>
        public const string MVSFXO = "MVSFXO";

        /// <summary>
        /// MVLNID.
        /// </summary>
        public const string MVLNID = "MVLNID";

        /// <summary>
        /// MVVSTY.
        /// </summary>
        public const string MVVSTY = "MVVSTY";

        /// <summary>
        /// MVVSSD.
        /// </summary>
        public const string MVVSSD = "MVVSSD";

        /// <summary>
        /// MVSTRT.
        /// </summary>
        public const string MVSTRT = "MVSTRT";

        /// <summary>
        /// MVPLQT.
        /// </summary>
        public const string MVPLQT = "MVPLQT";

        /// <summary>
        /// MVRLQT.
        /// </summary>
        public const string MVRLQT = "MVRLQT";

        /// <summary>
        /// MVHSQT.
        /// </summary>
        public const string MVHSQT = "MVHSQT";

        /// <summary>
        /// MVAN8.
        /// </summary>
        public const string MVAN8 = "MVAN8";

        /// <summary>
        /// MVPMPN.
        /// </summary>
        public const string MVPMPN = "MVPMPN";

        /// <summary>
        /// MVPNS.
        /// </summary>
        public const string MVPNS = "MVPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F3430";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MVITM", "MVITM", JdeDataType.Numeric),
        new JdeField("MVMCU", "MVMCU", JdeDataType.String, 24),
        new JdeField("MVKCOO", "MVKCOO", JdeDataType.String, 10, true, true),
        new JdeField("MVDOCO", "MVDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("MVDCTO", "MVDCTO", JdeDataType.String, 4, true, true),
        new JdeField("MVSFXO", "MVSFXO", JdeDataType.String, 6, true, true),
        new JdeField("MVLNID", "MVLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("MVVSTY", "MVVSTY", JdeDataType.String, 4),
        new JdeField("MVVSSD", "MVVSSD", JdeDataType.String, 2),
        new JdeField("MVSTRT", "MVSTRT", JdeDataType.Numeric, null, true, true),
        new JdeField("MVPLQT", "MVPLQT", JdeDataType.Numeric),
        new JdeField("MVRLQT", "MVRLQT", JdeDataType.Numeric),
        new JdeField("MVHSQT", "MVHSQT", JdeDataType.Numeric),
        new JdeField("MVAN8", "MVAN8", JdeDataType.Numeric),
        new JdeField("MVPMPN", "MVPMPN", JdeDataType.String, 60),
        new JdeField("MVPNS", "MVPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3430_0", "Primary Key on MVDOCO, MVDCTO, MVKCOO, MVSFXO, MVLNID, MVSTRT", new[] { "MVDOCO", "MVDCTO", "MVKCOO", "MVSFXO", "MVLNID", "MVSTRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3430_2", "Index on MVITM, MVMCU, MVDOCO, MVDCTO, MVKCOO, MVSFXO, MVLNID, MVSTRT", new[] { "MVITM", "MVMCU", "MVDOCO", "MVDCTO", "MVKCOO", "MVSFXO", "MVLNID", "MVSTRT" })
    };
}
