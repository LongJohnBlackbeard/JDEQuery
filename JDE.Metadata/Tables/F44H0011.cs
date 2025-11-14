using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H0011 - .
/// </summary>
public class F44H0011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDCO.
        /// </summary>
        public const string LDCO = "LDCO";

        /// <summary>
        /// LDOCTO.
        /// </summary>
        public const string LDOCTO = "LDOCTO";

        /// <summary>
        /// LDDCTO.
        /// </summary>
        public const string LDDCTO = "LDDCTO";

        /// <summary>
        /// LDLNTY.
        /// </summary>
        public const string LDLNTY = "LDLNTY";

        /// <summary>
        /// LDHBPFLG1.
        /// </summary>
        public const string LDHBPFLG1 = "LDHBPFLG1";

        /// <summary>
        /// LDNXTR.
        /// </summary>
        public const string LDNXTR = "LDNXTR";

        /// <summary>
        /// LDLTTR.
        /// </summary>
        public const string LDLTTR = "LDLTTR";

        /// <summary>
        /// LDCRTU.
        /// </summary>
        public const string LDCRTU = "LDCRTU";

        /// <summary>
        /// LDCRTJ.
        /// </summary>
        public const string LDCRTJ = "LDCRTJ";

        /// <summary>
        /// LDCRTT.
        /// </summary>
        public const string LDCRTT = "LDCRTT";

        /// <summary>
        /// LDWRKSTNID.
        /// </summary>
        public const string LDWRKSTNID = "LDWRKSTNID";

        /// <summary>
        /// LDHBOPID.
        /// </summary>
        public const string LDHBOPID = "LDHBOPID";

        /// <summary>
        /// LDUPMB.
        /// </summary>
        public const string LDUPMB = "LDUPMB";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H0011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDCO", "LDCO", JdeDataType.String, 10, true, true),
        new JdeField("LDOCTO", "LDOCTO", JdeDataType.String, 4, true, true),
        new JdeField("LDDCTO", "LDDCTO", JdeDataType.String, 4),
        new JdeField("LDLNTY", "LDLNTY", JdeDataType.String, 4),
        new JdeField("LDHBPFLG1", "LDHBPFLG1", JdeDataType.String, 2),
        new JdeField("LDNXTR", "LDNXTR", JdeDataType.String, 6),
        new JdeField("LDLTTR", "LDLTTR", JdeDataType.String, 6),
        new JdeField("LDCRTU", "LDCRTU", JdeDataType.String, 20),
        new JdeField("LDCRTJ", "LDCRTJ", JdeDataType.Numeric),
        new JdeField("LDCRTT", "LDCRTT", JdeDataType.Numeric),
        new JdeField("LDWRKSTNID", "LDWRKSTNID", JdeDataType.String, 20),
        new JdeField("LDHBOPID", "LDHBOPID", JdeDataType.String, 20),
        new JdeField("LDUPMB", "LDUPMB", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H0011_0", "Primary Key on LDCO, LDOCTO", new[] { "LDCO", "LDOCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
