using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A010 - .
/// </summary>
public class F76A010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RGCO.
        /// </summary>
        public const string RGCO = "RGCO";

        /// <summary>
        /// RGA76YEAR.
        /// </summary>
        public const string RGA76YEAR = "RGA76YEAR";

        /// <summary>
        /// RGA76MNTH.
        /// </summary>
        public const string RGA76MNTH = "RGA76MNTH";

        /// <summary>
        /// RGA76SEQN.
        /// </summary>
        public const string RGA76SEQN = "RGA76SEQN";

        /// <summary>
        /// RGA76ACGT.
        /// </summary>
        public const string RGA76ACGT = "RGA76ACGT";

        /// <summary>
        /// RGA76ACTX.
        /// </summary>
        public const string RGA76ACTX = "RGA76ACTX";

        /// <summary>
        /// RGA76CADA.
        /// </summary>
        public const string RGA76CADA = "RGA76CADA";

        /// <summary>
        /// RGA76CFPD.
        /// </summary>
        public const string RGA76CFPD = "RGA76CFPD";

        /// <summary>
        /// RGA76TCGA.
        /// </summary>
        public const string RGA76TCGA = "RGA76TCGA";

        /// <summary>
        /// RGA76PCTC.
        /// </summary>
        public const string RGA76PCTC = "RGA76PCTC";

        /// <summary>
        /// RGA76TRAR.
        /// </summary>
        public const string RGA76TRAR = "RGA76TRAR";

        /// <summary>
        /// RGA76TRAP.
        /// </summary>
        public const string RGA76TRAP = "RGA76TRAP";

        /// <summary>
        /// RGA76CTSS.
        /// </summary>
        public const string RGA76CTSS = "RGA76CTSS";

        /// <summary>
        /// RGA76CTCS.
        /// </summary>
        public const string RGA76CTCS = "RGA76CTCS";

        /// <summary>
        /// RGUSER.
        /// </summary>
        public const string RGUSER = "RGUSER";

        /// <summary>
        /// RGPID.
        /// </summary>
        public const string RGPID = "RGPID";

        /// <summary>
        /// RGJOBN.
        /// </summary>
        public const string RGJOBN = "RGJOBN";

        /// <summary>
        /// RGUPMJ.
        /// </summary>
        public const string RGUPMJ = "RGUPMJ";

        /// <summary>
        /// RGUPMT.
        /// </summary>
        public const string RGUPMT = "RGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RGCO", "RGCO", JdeDataType.String, 10, true, true),
        new JdeField("RGA76YEAR", "RGA76YEAR", JdeDataType.Numeric, null, true, true),
        new JdeField("RGA76MNTH", "RGA76MNTH", JdeDataType.Numeric, null, true, true),
        new JdeField("RGA76SEQN", "RGA76SEQN", JdeDataType.String, 4),
        new JdeField("RGA76ACGT", "RGA76ACGT", JdeDataType.Numeric),
        new JdeField("RGA76ACTX", "RGA76ACTX", JdeDataType.Numeric),
        new JdeField("RGA76CADA", "RGA76CADA", JdeDataType.Numeric),
        new JdeField("RGA76CFPD", "RGA76CFPD", JdeDataType.String, 2),
        new JdeField("RGA76TCGA", "RGA76TCGA", JdeDataType.Numeric),
        new JdeField("RGA76PCTC", "RGA76PCTC", JdeDataType.String, 2),
        new JdeField("RGA76TRAR", "RGA76TRAR", JdeDataType.String, 2),
        new JdeField("RGA76TRAP", "RGA76TRAP", JdeDataType.String, 2),
        new JdeField("RGA76CTSS", "RGA76CTSS", JdeDataType.Numeric),
        new JdeField("RGA76CTCS", "RGA76CTCS", JdeDataType.Numeric),
        new JdeField("RGUSER", "RGUSER", JdeDataType.String, 20),
        new JdeField("RGPID", "RGPID", JdeDataType.String, 20),
        new JdeField("RGJOBN", "RGJOBN", JdeDataType.String, 20),
        new JdeField("RGUPMJ", "RGUPMJ", JdeDataType.Numeric),
        new JdeField("RGUPMT", "RGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A010_0", "Primary Key on RGCO, RGA76YEAR, RGA76MNTH", new[] { "RGCO", "RGA76YEAR", "RGA76MNTH" }, isUnique: true, isPrimaryKey: true)
    };
}
