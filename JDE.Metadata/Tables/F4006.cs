using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4006 - .
/// </summary>
public class F4006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OADOCO.
        /// </summary>
        public const string OADOCO = "OADOCO";

        /// <summary>
        /// OADCTO.
        /// </summary>
        public const string OADCTO = "OADCTO";

        /// <summary>
        /// OAKCOO.
        /// </summary>
        public const string OAKCOO = "OAKCOO";

        /// <summary>
        /// OAANTY.
        /// </summary>
        public const string OAANTY = "OAANTY";

        /// <summary>
        /// OAMLNM.
        /// </summary>
        public const string OAMLNM = "OAMLNM";

        /// <summary>
        /// OAADD1.
        /// </summary>
        public const string OAADD1 = "OAADD1";

        /// <summary>
        /// OAADD2.
        /// </summary>
        public const string OAADD2 = "OAADD2";

        /// <summary>
        /// OAADD3.
        /// </summary>
        public const string OAADD3 = "OAADD3";

        /// <summary>
        /// OAADD4.
        /// </summary>
        public const string OAADD4 = "OAADD4";

        /// <summary>
        /// OAADDZ.
        /// </summary>
        public const string OAADDZ = "OAADDZ";

        /// <summary>
        /// OACTY1.
        /// </summary>
        public const string OACTY1 = "OACTY1";

        /// <summary>
        /// OACOUN.
        /// </summary>
        public const string OACOUN = "OACOUN";

        /// <summary>
        /// OAADDS.
        /// </summary>
        public const string OAADDS = "OAADDS";

        /// <summary>
        /// OACRTE.
        /// </summary>
        public const string OACRTE = "OACRTE";

        /// <summary>
        /// OABKML.
        /// </summary>
        public const string OABKML = "OABKML";

        /// <summary>
        /// OACTR.
        /// </summary>
        public const string OACTR = "OACTR";

        /// <summary>
        /// OAUSER.
        /// </summary>
        public const string OAUSER = "OAUSER";

        /// <summary>
        /// OAPID.
        /// </summary>
        public const string OAPID = "OAPID";

        /// <summary>
        /// OAUPMJ.
        /// </summary>
        public const string OAUPMJ = "OAUPMJ";

        /// <summary>
        /// OAJOBN.
        /// </summary>
        public const string OAJOBN = "OAJOBN";

        /// <summary>
        /// OAUPMT.
        /// </summary>
        public const string OAUPMT = "OAUPMT";

        /// <summary>
        /// OALNID.
        /// </summary>
        public const string OALNID = "OALNID";
    }

    /// <inheritdoc />
    public override string TableName => "F4006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OADOCO", "OADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OADCTO", "OADCTO", JdeDataType.String, 4, true, true),
        new JdeField("OAKCOO", "OAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("OAANTY", "OAANTY", JdeDataType.String, 2, true, true),
        new JdeField("OAMLNM", "OAMLNM", JdeDataType.String, 80),
        new JdeField("OAADD1", "OAADD1", JdeDataType.String, 80),
        new JdeField("OAADD2", "OAADD2", JdeDataType.String, 80),
        new JdeField("OAADD3", "OAADD3", JdeDataType.String, 80),
        new JdeField("OAADD4", "OAADD4", JdeDataType.String, 80),
        new JdeField("OAADDZ", "OAADDZ", JdeDataType.String, 24),
        new JdeField("OACTY1", "OACTY1", JdeDataType.String, 50),
        new JdeField("OACOUN", "OACOUN", JdeDataType.String, 50),
        new JdeField("OAADDS", "OAADDS", JdeDataType.String, 6),
        new JdeField("OACRTE", "OACRTE", JdeDataType.String, 8),
        new JdeField("OABKML", "OABKML", JdeDataType.String, 4),
        new JdeField("OACTR", "OACTR", JdeDataType.String, 6),
        new JdeField("OAUSER", "OAUSER", JdeDataType.String, 20),
        new JdeField("OAPID", "OAPID", JdeDataType.String, 20),
        new JdeField("OAUPMJ", "OAUPMJ", JdeDataType.Numeric),
        new JdeField("OAJOBN", "OAJOBN", JdeDataType.String, 20),
        new JdeField("OAUPMT", "OAUPMT", JdeDataType.Numeric),
        new JdeField("OALNID", "OALNID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4006_0", "Primary Key on OADOCO, OADCTO, OAKCOO, OAANTY", new[] { "OADOCO", "OADCTO", "OAKCOO", "OAANTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4006_2", "Index on OAKCOO, OADCTO, OADOCO", new[] { "OAKCOO", "OADCTO", "OADOCO" })
    };
}
