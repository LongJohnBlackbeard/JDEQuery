using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4332 - .
/// </summary>
public class F4332 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P2KCOO.
        /// </summary>
        public const string P2KCOO = "P2KCOO";

        /// <summary>
        /// P2DOCO.
        /// </summary>
        public const string P2DOCO = "P2DOCO";

        /// <summary>
        /// P2DCTO.
        /// </summary>
        public const string P2DCTO = "P2DCTO";

        /// <summary>
        /// P2LNID.
        /// </summary>
        public const string P2LNID = "P2LNID";

        /// <summary>
        /// P2OORN.
        /// </summary>
        public const string P2OORN = "P2OORN";

        /// <summary>
        /// P2OCTO.
        /// </summary>
        public const string P2OCTO = "P2OCTO";

        /// <summary>
        /// P2OKCO.
        /// </summary>
        public const string P2OKCO = "P2OKCO";

        /// <summary>
        /// P2OGNO.
        /// </summary>
        public const string P2OGNO = "P2OGNO";

        /// <summary>
        /// P2SHAN.
        /// </summary>
        public const string P2SHAN = "P2SHAN";

        /// <summary>
        /// P2UREQ.
        /// </summary>
        public const string P2UREQ = "P2UREQ";

        /// <summary>
        /// P2ARQU.
        /// </summary>
        public const string P2ARQU = "P2ARQU";

        /// <summary>
        /// P2UREL.
        /// </summary>
        public const string P2UREL = "P2UREL";

        /// <summary>
        /// P2AREL.
        /// </summary>
        public const string P2AREL = "P2AREL";

        /// <summary>
        /// P2SFXO.
        /// </summary>
        public const string P2SFXO = "P2SFXO";
    }

    /// <inheritdoc />
    public override string TableName => "F4332";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P2KCOO", "P2KCOO", JdeDataType.String, 10, true, true),
        new JdeField("P2DOCO", "P2DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P2DCTO", "P2DCTO", JdeDataType.String, 4, true, true),
        new JdeField("P2LNID", "P2LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P2OORN", "P2OORN", JdeDataType.String, 16, true, true),
        new JdeField("P2OCTO", "P2OCTO", JdeDataType.String, 4, true, true),
        new JdeField("P2OKCO", "P2OKCO", JdeDataType.String, 10, true, true),
        new JdeField("P2OGNO", "P2OGNO", JdeDataType.Numeric, null, true, true),
        new JdeField("P2SHAN", "P2SHAN", JdeDataType.Numeric),
        new JdeField("P2UREQ", "P2UREQ", JdeDataType.Numeric),
        new JdeField("P2ARQU", "P2ARQU", JdeDataType.Numeric),
        new JdeField("P2UREL", "P2UREL", JdeDataType.Numeric),
        new JdeField("P2AREL", "P2AREL", JdeDataType.Numeric),
        new JdeField("P2SFXO", "P2SFXO", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4332_0", "Primary Key on P2DOCO, P2DCTO, P2KCOO, P2SFXO, P2LNID, P2OORN, P2OCTO, P2OKCO, P2OGNO", new[] { "P2DOCO", "P2DCTO", "P2KCOO", "P2SFXO", "P2LNID", "P2OORN", "P2OCTO", "P2OKCO", "P2OGNO" }, isUnique: true, isPrimaryKey: true)
    };
}
