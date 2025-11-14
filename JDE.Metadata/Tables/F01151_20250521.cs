using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01151_20250521 - .
/// </summary>
public class F01151_20250521 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EAAN8.
        /// </summary>
        public const string EAAN8 = "EAAN8";

        /// <summary>
        /// EAIDLN.
        /// </summary>
        public const string EAIDLN = "EAIDLN";

        /// <summary>
        /// EARCK7.
        /// </summary>
        public const string EARCK7 = "EARCK7";

        /// <summary>
        /// EAETP.
        /// </summary>
        public const string EAETP = "EAETP";

        /// <summary>
        /// EAEMAL.
        /// </summary>
        public const string EAEMAL = "EAEMAL";

        /// <summary>
        /// EAUSER.
        /// </summary>
        public const string EAUSER = "EAUSER";

        /// <summary>
        /// EAPID.
        /// </summary>
        public const string EAPID = "EAPID";

        /// <summary>
        /// EAUPMJ.
        /// </summary>
        public const string EAUPMJ = "EAUPMJ";

        /// <summary>
        /// EAJOBN.
        /// </summary>
        public const string EAJOBN = "EAJOBN";

        /// <summary>
        /// EAUPMT.
        /// </summary>
        public const string EAUPMT = "EAUPMT";

        /// <summary>
        /// EAEHIER.
        /// </summary>
        public const string EAEHIER = "EAEHIER";

        /// <summary>
        /// EAEFOR.
        /// </summary>
        public const string EAEFOR = "EAEFOR";

        /// <summary>
        /// EAECLASS.
        /// </summary>
        public const string EAECLASS = "EAECLASS";

        /// <summary>
        /// EACFNO1.
        /// </summary>
        public const string EACFNO1 = "EACFNO1";

        /// <summary>
        /// EAGEN1.
        /// </summary>
        public const string EAGEN1 = "EAGEN1";

        /// <summary>
        /// EAFALGE.
        /// </summary>
        public const string EAFALGE = "EAFALGE";

        /// <summary>
        /// EASYNCS.
        /// </summary>
        public const string EASYNCS = "EASYNCS";

        /// <summary>
        /// EACAAD.
        /// </summary>
        public const string EACAAD = "EACAAD";
    }

    /// <inheritdoc />
    public override string TableName => "F01151_20250521";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EAAN8", "EAAN8", JdeDataType.Numeric),
        new JdeField("EAIDLN", "EAIDLN", JdeDataType.Numeric),
        new JdeField("EARCK7", "EARCK7", JdeDataType.Numeric),
        new JdeField("EAETP", "EAETP", JdeDataType.String, 8),
        new JdeField("EAEMAL", "EAEMAL", JdeDataType.String, 512),
        new JdeField("EAUSER", "EAUSER", JdeDataType.String, 20),
        new JdeField("EAPID", "EAPID", JdeDataType.String, 20),
        new JdeField("EAUPMJ", "EAUPMJ", JdeDataType.Numeric),
        new JdeField("EAJOBN", "EAJOBN", JdeDataType.String, 20),
        new JdeField("EAUPMT", "EAUPMT", JdeDataType.Numeric),
        new JdeField("EAEHIER", "EAEHIER", JdeDataType.Numeric),
        new JdeField("EAEFOR", "EAEFOR", JdeDataType.String, 30),
        new JdeField("EAECLASS", "EAECLASS", JdeDataType.String, 6),
        new JdeField("EACFNO1", "EACFNO1", JdeDataType.Numeric),
        new JdeField("EAGEN1", "EAGEN1", JdeDataType.String, 20),
        new JdeField("EAFALGE", "EAFALGE", JdeDataType.String, 2),
        new JdeField("EASYNCS", "EASYNCS", JdeDataType.Numeric),
        new JdeField("EACAAD", "EACAAD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
    };
}
