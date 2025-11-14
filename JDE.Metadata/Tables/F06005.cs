using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06005 - .
/// </summary>
public class F06005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JEVERS.
        /// </summary>
        public const string JEVERS = "JEVERS";

        /// <summary>
        /// JEPID.
        /// </summary>
        public const string JEPID = "JEPID";

        /// <summary>
        /// JEVER1.
        /// </summary>
        public const string JEVER1 = "JEVER1";

        /// <summary>
        /// JEOVPC.
        /// </summary>
        public const string JEOVPC = "JEOVPC";

        /// <summary>
        /// JEPFRQ.
        /// </summary>
        public const string JEPFRQ = "JEPFRQ";

        /// <summary>
        /// JEPTCT.
        /// </summary>
        public const string JEPTCT = "JEPTCT";

        /// <summary>
        /// JEPT2C.
        /// </summary>
        public const string JEPT2C = "JEPT2C";

        /// <summary>
        /// JEPT3C.
        /// </summary>
        public const string JEPT3C = "JEPT3C";

        /// <summary>
        /// JEEFTB.
        /// </summary>
        public const string JEEFTB = "JEEFTB";

        /// <summary>
        /// JEEFTE.
        /// </summary>
        public const string JEEFTE = "JEEFTE";

        /// <summary>
        /// JERHPD.
        /// </summary>
        public const string JERHPD = "JERHPD";

        /// <summary>
        /// JEOHPD.
        /// </summary>
        public const string JEOHPD = "JEOHPD";

        /// <summary>
        /// JERHPW.
        /// </summary>
        public const string JERHPW = "JERHPW";

        /// <summary>
        /// JEOHPW.
        /// </summary>
        public const string JEOHPW = "JEOHPW";

        /// <summary>
        /// JEPDBA.
        /// </summary>
        public const string JEPDBA = "JEPDBA";

        /// <summary>
        /// JEOTPT.
        /// </summary>
        public const string JEOTPT = "JEOTPT";

        /// <summary>
        /// JETCAL.
        /// </summary>
        public const string JETCAL = "JETCAL";

        /// <summary>
        /// JERTCN.
        /// </summary>
        public const string JERTCN = "JERTCN";

        /// <summary>
        /// JELBDS.
        /// </summary>
        public const string JELBDS = "JELBDS";

        /// <summary>
        /// JEDTAB.
        /// </summary>
        public const string JEDTAB = "JEDTAB";

        /// <summary>
        /// JEPT4C.
        /// </summary>
        public const string JEPT4C = "JEPT4C";

        /// <summary>
        /// JEPT5C.
        /// </summary>
        public const string JEPT5C = "JEPT5C";

        /// <summary>
        /// JEPT6C.
        /// </summary>
        public const string JEPT6C = "JEPT6C";

        /// <summary>
        /// JEPT7C.
        /// </summary>
        public const string JEPT7C = "JEPT7C";

        /// <summary>
        /// JEPT8C.
        /// </summary>
        public const string JEPT8C = "JEPT8C";

        /// <summary>
        /// JEPT9C.
        /// </summary>
        public const string JEPT9C = "JEPT9C";

        /// <summary>
        /// JEPT0C.
        /// </summary>
        public const string JEPT0C = "JEPT0C";

        /// <summary>
        /// JEPF1.
        /// </summary>
        public const string JEPF1 = "JEPF1";

        /// <summary>
        /// JEPF2.
        /// </summary>
        public const string JEPF2 = "JEPF2";

        /// <summary>
        /// JEPF3.
        /// </summary>
        public const string JEPF3 = "JEPF3";
    }

    /// <inheritdoc />
    public override string TableName => "F06005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JEVERS", "JEVERS", JdeDataType.String, 20, true, true),
        new JdeField("JEPID", "JEPID", JdeDataType.String, 20, true, true),
        new JdeField("JEVER1", "JEVER1", JdeDataType.String, 20),
        new JdeField("JEOVPC", "JEOVPC", JdeDataType.String, 2),
        new JdeField("JEPFRQ", "JEPFRQ", JdeDataType.String, 2),
        new JdeField("JEPTCT", "JEPTCT", JdeDataType.String, 2),
        new JdeField("JEPT2C", "JEPT2C", JdeDataType.String, 2),
        new JdeField("JEPT3C", "JEPT3C", JdeDataType.String, 2),
        new JdeField("JEEFTB", "JEEFTB", JdeDataType.Numeric),
        new JdeField("JEEFTE", "JEEFTE", JdeDataType.Numeric),
        new JdeField("JERHPD", "JERHPD", JdeDataType.Numeric),
        new JdeField("JEOHPD", "JEOHPD", JdeDataType.Numeric),
        new JdeField("JERHPW", "JERHPW", JdeDataType.Numeric),
        new JdeField("JEOHPW", "JEOHPW", JdeDataType.Numeric),
        new JdeField("JEPDBA", "JEPDBA", JdeDataType.Numeric),
        new JdeField("JEOTPT", "JEOTPT", JdeDataType.Numeric),
        new JdeField("JETCAL", "JETCAL", JdeDataType.String, 2),
        new JdeField("JERTCN", "JERTCN", JdeDataType.String, 2),
        new JdeField("JELBDS", "JELBDS", JdeDataType.String, 2),
        new JdeField("JEDTAB", "JEDTAB", JdeDataType.String, 10),
        new JdeField("JEPT4C", "JEPT4C", JdeDataType.String, 2),
        new JdeField("JEPT5C", "JEPT5C", JdeDataType.String, 2),
        new JdeField("JEPT6C", "JEPT6C", JdeDataType.String, 2),
        new JdeField("JEPT7C", "JEPT7C", JdeDataType.String, 2),
        new JdeField("JEPT8C", "JEPT8C", JdeDataType.String, 2),
        new JdeField("JEPT9C", "JEPT9C", JdeDataType.String, 2),
        new JdeField("JEPT0C", "JEPT0C", JdeDataType.String, 2),
        new JdeField("JEPF1", "JEPF1", JdeDataType.String, 2),
        new JdeField("JEPF2", "JEPF2", JdeDataType.String, 2),
        new JdeField("JEPF3", "JEPF3", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06005_0", "Primary Key on JEPID, JEVERS", new[] { "JEPID", "JEVERS" }, isUnique: true, isPrimaryKey: true)
    };
}
