using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4290 - .
/// </summary>
public class F4290 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SEDELN.
        /// </summary>
        public const string SEDELN = "SEDELN";

        /// <summary>
        /// SEDDEL.
        /// </summary>
        public const string SEDDEL = "SEDDEL";

        /// <summary>
        /// SEMCU.
        /// </summary>
        public const string SEMCU = "SEMCU";

        /// <summary>
        /// SESHAN.
        /// </summary>
        public const string SESHAN = "SESHAN";

        /// <summary>
        /// SEKCOO.
        /// </summary>
        public const string SEKCOO = "SEKCOO";

        /// <summary>
        /// SEDOCO.
        /// </summary>
        public const string SEDOCO = "SEDOCO";

        /// <summary>
        /// SEDCTO.
        /// </summary>
        public const string SEDCTO = "SEDCTO";

        /// <summary>
        /// SESFXO.
        /// </summary>
        public const string SESFXO = "SESFXO";

        /// <summary>
        /// SELNID.
        /// </summary>
        public const string SELNID = "SELNID";

        /// <summary>
        /// SECARS.
        /// </summary>
        public const string SECARS = "SECARS";

        /// <summary>
        /// SESHCN.
        /// </summary>
        public const string SESHCN = "SESHCN";

        /// <summary>
        /// SESHCM.
        /// </summary>
        public const string SESHCM = "SESHCM";

        /// <summary>
        /// SEFRTH.
        /// </summary>
        public const string SEFRTH = "SEFRTH";

        /// <summary>
        /// SETRRS.
        /// </summary>
        public const string SETRRS = "SETRRS";

        /// <summary>
        /// SEITM.
        /// </summary>
        public const string SEITM = "SEITM";

        /// <summary>
        /// SEITWT.
        /// </summary>
        public const string SEITWT = "SEITWT";

        /// <summary>
        /// SEITVL.
        /// </summary>
        public const string SEITVL = "SEITVL";

        /// <summary>
        /// SESOQS.
        /// </summary>
        public const string SESOQS = "SESOQS";

        /// <summary>
        /// SEUOM.
        /// </summary>
        public const string SEUOM = "SEUOM";
    }

    /// <inheritdoc />
    public override string TableName => "F4290";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SEDELN", "SEDELN", JdeDataType.Numeric, null, true, true),
        new JdeField("SEDDEL", "SEDDEL", JdeDataType.Numeric),
        new JdeField("SEMCU", "SEMCU", JdeDataType.String, 24),
        new JdeField("SESHAN", "SESHAN", JdeDataType.Numeric),
        new JdeField("SEKCOO", "SEKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SEDOCO", "SEDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SEDCTO", "SEDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SESFXO", "SESFXO", JdeDataType.String, 6),
        new JdeField("SELNID", "SELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SECARS", "SECARS", JdeDataType.Numeric),
        new JdeField("SESHCN", "SESHCN", JdeDataType.String, 6),
        new JdeField("SESHCM", "SESHCM", JdeDataType.String, 6),
        new JdeField("SEFRTH", "SEFRTH", JdeDataType.String, 6),
        new JdeField("SETRRS", "SETRRS", JdeDataType.String, 6),
        new JdeField("SEITM", "SEITM", JdeDataType.Numeric),
        new JdeField("SEITWT", "SEITWT", JdeDataType.Numeric),
        new JdeField("SEITVL", "SEITVL", JdeDataType.Numeric),
        new JdeField("SESOQS", "SESOQS", JdeDataType.Numeric),
        new JdeField("SEUOM", "SEUOM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4290_0", "Primary Key on SEDELN, SEDOCO, SEDCTO, SEKCOO, SELNID", new[] { "SEDELN", "SEDOCO", "SEDCTO", "SEKCOO", "SELNID" }, isUnique: true, isPrimaryKey: true)
    };
}
