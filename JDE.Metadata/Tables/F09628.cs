using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09628 - .
/// </summary>
public class F09628 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GAAID.
        /// </summary>
        public const string GAAID = "GAAID";

        /// <summary>
        /// GARECGRP.
        /// </summary>
        public const string GARECGRP = "GARECGRP";

        /// <summary>
        /// GARECRULE.
        /// </summary>
        public const string GARECRULE = "GARECRULE";

        /// <summary>
        /// GACO.
        /// </summary>
        public const string GACO = "GACO";

        /// <summary>
        /// GAGLR3FLG.
        /// </summary>
        public const string GAGLR3FLG = "GAGLR3FLG";

        /// <summary>
        /// GATKTX.
        /// </summary>
        public const string GATKTX = "GATKTX";

        /// <summary>
        /// GATXA1.
        /// </summary>
        public const string GATXA1 = "GATXA1";

        /// <summary>
        /// GAEXR1.
        /// </summary>
        public const string GAEXR1 = "GAEXR1";

        /// <summary>
        /// GAPID.
        /// </summary>
        public const string GAPID = "GAPID";

        /// <summary>
        /// GAUSER.
        /// </summary>
        public const string GAUSER = "GAUSER";

        /// <summary>
        /// GAJOBN.
        /// </summary>
        public const string GAJOBN = "GAJOBN";

        /// <summary>
        /// GAUPMJ.
        /// </summary>
        public const string GAUPMJ = "GAUPMJ";

        /// <summary>
        /// GAUPMT.
        /// </summary>
        public const string GAUPMT = "GAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09628";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GAAID", "GAAID", JdeDataType.String, 16, true, true),
        new JdeField("GARECGRP", "GARECGRP", JdeDataType.String, 20),
        new JdeField("GARECRULE", "GARECRULE", JdeDataType.String, 20),
        new JdeField("GACO", "GACO", JdeDataType.String, 10),
        new JdeField("GAGLR3FLG", "GAGLR3FLG", JdeDataType.String, 2),
        new JdeField("GATKTX", "GATKTX", JdeDataType.String, 2),
        new JdeField("GATXA1", "GATXA1", JdeDataType.String, 20),
        new JdeField("GAEXR1", "GAEXR1", JdeDataType.String, 4),
        new JdeField("GAPID", "GAPID", JdeDataType.String, 20),
        new JdeField("GAUSER", "GAUSER", JdeDataType.String, 20),
        new JdeField("GAJOBN", "GAJOBN", JdeDataType.String, 20),
        new JdeField("GAUPMJ", "GAUPMJ", JdeDataType.Numeric),
        new JdeField("GAUPMT", "GAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09628_0", "Primary Key on GAAID", new[] { "GAAID" }, isUnique: true, isPrimaryKey: true)
    };
}
