using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A0403 - .
/// </summary>
public class F76A0403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AWCO.
        /// </summary>
        public const string AWCO = "AWCO";

        /// <summary>
        /// AWA004.
        /// </summary>
        public const string AWA004 = "AWA004";

        /// <summary>
        /// AWA76NW.
        /// </summary>
        public const string AWA76NW = "AWA76NW";

        /// <summary>
        /// AWA76NWR.
        /// </summary>
        public const string AWA76NWR = "AWA76NWR";

        /// <summary>
        /// AWA76ACDI.
        /// </summary>
        public const string AWA76ACDI = "AWA76ACDI";

        /// <summary>
        /// AWA76COA.
        /// </summary>
        public const string AWA76COA = "AWA76COA";

        /// <summary>
        /// AWA76CAC.
        /// </summary>
        public const string AWA76CAC = "AWA76CAC";

        /// <summary>
        /// AWUSER.
        /// </summary>
        public const string AWUSER = "AWUSER";

        /// <summary>
        /// AWPID.
        /// </summary>
        public const string AWPID = "AWPID";

        /// <summary>
        /// AWJOBN.
        /// </summary>
        public const string AWJOBN = "AWJOBN";

        /// <summary>
        /// AWUPMJ.
        /// </summary>
        public const string AWUPMJ = "AWUPMJ";

        /// <summary>
        /// AWUPMT.
        /// </summary>
        public const string AWUPMT = "AWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A0403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AWCO", "AWCO", JdeDataType.String, 10, true, true),
        new JdeField("AWA004", "AWA004", JdeDataType.String, 6, true, true),
        new JdeField("AWA76NW", "AWA76NW", JdeDataType.String, 2),
        new JdeField("AWA76NWR", "AWA76NWR", JdeDataType.String, 60),
        new JdeField("AWA76ACDI", "AWA76ACDI", JdeDataType.String, 2),
        new JdeField("AWA76COA", "AWA76COA", JdeDataType.Numeric),
        new JdeField("AWA76CAC", "AWA76CAC", JdeDataType.Numeric),
        new JdeField("AWUSER", "AWUSER", JdeDataType.String, 20),
        new JdeField("AWPID", "AWPID", JdeDataType.String, 20),
        new JdeField("AWJOBN", "AWJOBN", JdeDataType.String, 20),
        new JdeField("AWUPMJ", "AWUPMJ", JdeDataType.Numeric),
        new JdeField("AWUPMT", "AWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A0403_0", "Primary Key on AWCO, AWA004", new[] { "AWCO", "AWA004" }, isUnique: true, isPrimaryKey: true)
    };
}
