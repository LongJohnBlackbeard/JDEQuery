using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4802S - .
/// </summary>
public class F4802S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WBDOCO.
        /// </summary>
        public const string WBDOCO = "WBDOCO";

        /// <summary>
        /// WBDCTO.
        /// </summary>
        public const string WBDCTO = "WBDCTO";

        /// <summary>
        /// WBSFXO.
        /// </summary>
        public const string WBSFXO = "WBSFXO";

        /// <summary>
        /// WBTYPR.
        /// </summary>
        public const string WBTYPR = "WBTYPR";

        /// <summary>
        /// WBLINS.
        /// </summary>
        public const string WBLINS = "WBLINS";

        /// <summary>
        /// WBDAA.
        /// </summary>
        public const string WBDAA = "WBDAA";

        /// <summary>
        /// WBSRDS.
        /// </summary>
        public const string WBSRDS = "WBSRDS";

        /// <summary>
        /// WBANM1.
        /// </summary>
        public const string WBANM1 = "WBANM1";

        /// <summary>
        /// WBANM2.
        /// </summary>
        public const string WBANM2 = "WBANM2";

        /// <summary>
        /// WBANM3.
        /// </summary>
        public const string WBANM3 = "WBANM3";
    }

    /// <inheritdoc />
    public override string TableName => "F4802S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WBDOCO", "WBDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WBDCTO", "WBDCTO", JdeDataType.String, 4, true, true),
        new JdeField("WBSFXO", "WBSFXO", JdeDataType.String, 6, true, true),
        new JdeField("WBTYPR", "WBTYPR", JdeDataType.String, 2, true, true),
        new JdeField("WBLINS", "WBLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("WBDAA", "WBDAA", JdeDataType.Numeric),
        new JdeField("WBSRDS", "WBSRDS", JdeDataType.String, 120),
        new JdeField("WBANM1", "WBANM1", JdeDataType.String, 20),
        new JdeField("WBANM2", "WBANM2", JdeDataType.String, 20),
        new JdeField("WBANM3", "WBANM3", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4802S_0", "Primary Key on WBDOCO, WBDCTO, WBSFXO, WBTYPR, WBLINS", new[] { "WBDOCO", "WBDCTO", "WBSFXO", "WBTYPR", "WBLINS" }, isUnique: true, isPrimaryKey: true)
    };
}
