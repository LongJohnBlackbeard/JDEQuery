using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0040 - .
/// </summary>
public class F0040 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DPRETE.
        /// </summary>
        public const string DPRETE = "DPRETE";

        /// <summary>
        /// DPDPUSER.
        /// </summary>
        public const string DPDPUSER = "DPDPUSER";

        /// <summary>
        /// DPDPPID.
        /// </summary>
        public const string DPDPPID = "DPDPPID";

        /// <summary>
        /// DPVWUP.
        /// </summary>
        public const string DPVWUP = "DPVWUP";

        /// <summary>
        /// DPPID.
        /// </summary>
        public const string DPPID = "DPPID";

        /// <summary>
        /// DPUPMJ.
        /// </summary>
        public const string DPUPMJ = "DPUPMJ";

        /// <summary>
        /// DPUPMT.
        /// </summary>
        public const string DPUPMT = "DPUPMT";

        /// <summary>
        /// DPUSER.
        /// </summary>
        public const string DPUSER = "DPUSER";

        /// <summary>
        /// DPMKEY.
        /// </summary>
        public const string DPMKEY = "DPMKEY";

        /// <summary>
        /// DPDPCH1.
        /// </summary>
        public const string DPDPCH1 = "DPDPCH1";

        /// <summary>
        /// DPDPCH2.
        /// </summary>
        public const string DPDPCH2 = "DPDPCH2";

        /// <summary>
        /// DPCFST1.
        /// </summary>
        public const string DPCFST1 = "DPCFST1";

        /// <summary>
        /// DPCFST2.
        /// </summary>
        public const string DPCFST2 = "DPCFST2";

        /// <summary>
        /// DPCFMN1.
        /// </summary>
        public const string DPCFMN1 = "DPCFMN1";

        /// <summary>
        /// DPCFMN2.
        /// </summary>
        public const string DPCFMN2 = "DPCFMN2";

        /// <summary>
        /// DPCFDT1.
        /// </summary>
        public const string DPCFDT1 = "DPCFDT1";

        /// <summary>
        /// DPCFDT2.
        /// </summary>
        public const string DPCFDT2 = "DPCFDT2";
    }

    /// <inheritdoc />
    public override string TableName => "F0040";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DPRETE", "DPRETE", JdeDataType.String, 2, true, true),
        new JdeField("DPDPUSER", "DPDPUSER", JdeDataType.String, 20, true, true),
        new JdeField("DPDPPID", "DPDPPID", JdeDataType.String, 20, true, true),
        new JdeField("DPVWUP", "DPVWUP", JdeDataType.String, 2),
        new JdeField("DPPID", "DPPID", JdeDataType.String, 20),
        new JdeField("DPUPMJ", "DPUPMJ", JdeDataType.Numeric),
        new JdeField("DPUPMT", "DPUPMT", JdeDataType.Numeric),
        new JdeField("DPUSER", "DPUSER", JdeDataType.String, 20),
        new JdeField("DPMKEY", "DPMKEY", JdeDataType.String, 30),
        new JdeField("DPDPCH1", "DPDPCH1", JdeDataType.String, 2),
        new JdeField("DPDPCH2", "DPDPCH2", JdeDataType.String, 2),
        new JdeField("DPCFST1", "DPCFST1", JdeDataType.String, 160),
        new JdeField("DPCFST2", "DPCFST2", JdeDataType.String, 160),
        new JdeField("DPCFMN1", "DPCFMN1", JdeDataType.Numeric),
        new JdeField("DPCFMN2", "DPCFMN2", JdeDataType.Numeric),
        new JdeField("DPCFDT1", "DPCFDT1", JdeDataType.Numeric),
        new JdeField("DPCFDT2", "DPCFDT2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0040_0", "Primary Key on DPRETE, DPDPUSER, DPDPPID", new[] { "DPRETE", "DPDPUSER", "DPDPPID" }, isUnique: true, isPrimaryKey: true)
    };
}
