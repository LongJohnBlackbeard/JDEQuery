using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4211CZ1 - .
/// </summary>
public class F4211CZ1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CZEDUS.
        /// </summary>
        public const string CZEDUS = "CZEDUS";

        /// <summary>
        /// CZEDBT.
        /// </summary>
        public const string CZEDBT = "CZEDBT";

        /// <summary>
        /// CZEDTN.
        /// </summary>
        public const string CZEDTN = "CZEDTN";

        /// <summary>
        /// CZEDLN.
        /// </summary>
        public const string CZEDLN = "CZEDLN";

        /// <summary>
        /// CZEDCT.
        /// </summary>
        public const string CZEDCT = "CZEDCT";

        /// <summary>
        /// CZEDFT.
        /// </summary>
        public const string CZEDFT = "CZEDFT";

        /// <summary>
        /// CZEDDT.
        /// </summary>
        public const string CZEDDT = "CZEDDT";

        /// <summary>
        /// CZEDDL.
        /// </summary>
        public const string CZEDDL = "CZEDDL";

        /// <summary>
        /// CZEDSP.
        /// </summary>
        public const string CZEDSP = "CZEDSP";

        /// <summary>
        /// CZDOCO.
        /// </summary>
        public const string CZDOCO = "CZDOCO";

        /// <summary>
        /// CZDCTO.
        /// </summary>
        public const string CZDCTO = "CZDCTO";

        /// <summary>
        /// CZKCOO.
        /// </summary>
        public const string CZKCOO = "CZKCOO";

        /// <summary>
        /// CZLNID.
        /// </summary>
        public const string CZLNID = "CZLNID";

        /// <summary>
        /// CZPRAN8.
        /// </summary>
        public const string CZPRAN8 = "CZPRAN8";

        /// <summary>
        /// CZPRCIDLN.
        /// </summary>
        public const string CZPRCIDLN = "CZPRCIDLN";

        /// <summary>
        /// CZCCIDLN.
        /// </summary>
        public const string CZCCIDLN = "CZCCIDLN";

        /// <summary>
        /// CZSPATTN.
        /// </summary>
        public const string CZSPATTN = "CZSPATTN";

        /// <summary>
        /// CZSHCCIDLN.
        /// </summary>
        public const string CZSHCCIDLN = "CZSHCCIDLN";

        /// <summary>
        /// CZOPPID.
        /// </summary>
        public const string CZOPPID = "CZOPPID";

        /// <summary>
        /// CZOSTP.
        /// </summary>
        public const string CZOSTP = "CZOSTP";

        /// <summary>
        /// CZUKID.
        /// </summary>
        public const string CZUKID = "CZUKID";

        /// <summary>
        /// CZCATNM.
        /// </summary>
        public const string CZCATNM = "CZCATNM";
    }

    /// <inheritdoc />
    public override string TableName => "F4211CZ1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CZEDUS", "CZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("CZEDBT", "CZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("CZEDTN", "CZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("CZEDLN", "CZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CZEDCT", "CZEDCT", JdeDataType.String, 4),
        new JdeField("CZEDFT", "CZEDFT", JdeDataType.String, 20),
        new JdeField("CZEDDT", "CZEDDT", JdeDataType.Numeric),
        new JdeField("CZEDDL", "CZEDDL", JdeDataType.Numeric),
        new JdeField("CZEDSP", "CZEDSP", JdeDataType.String, 2),
        new JdeField("CZDOCO", "CZDOCO", JdeDataType.Numeric),
        new JdeField("CZDCTO", "CZDCTO", JdeDataType.String, 4),
        new JdeField("CZKCOO", "CZKCOO", JdeDataType.String, 10),
        new JdeField("CZLNID", "CZLNID", JdeDataType.Numeric),
        new JdeField("CZPRAN8", "CZPRAN8", JdeDataType.Numeric),
        new JdeField("CZPRCIDLN", "CZPRCIDLN", JdeDataType.Numeric),
        new JdeField("CZCCIDLN", "CZCCIDLN", JdeDataType.Numeric),
        new JdeField("CZSPATTN", "CZSPATTN", JdeDataType.String, 100),
        new JdeField("CZSHCCIDLN", "CZSHCCIDLN", JdeDataType.Numeric),
        new JdeField("CZOPPID", "CZOPPID", JdeDataType.Numeric),
        new JdeField("CZOSTP", "CZOSTP", JdeDataType.String, 6),
        new JdeField("CZUKID", "CZUKID", JdeDataType.Numeric),
        new JdeField("CZCATNM", "CZCATNM", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4211CZ1_0", "Primary Key on CZEDUS, CZEDBT, CZEDTN, CZEDLN", new[] { "CZEDUS", "CZEDBT", "CZEDTN", "CZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4211CZ1_2", "Index on CZDOCO, CZDCTO, CZKCOO, CZEDUS, CZLNID", new[] { "CZDOCO", "CZDCTO", "CZKCOO", "CZEDUS", "CZLNID" }),
        new JdeIndex("F4211CZ1_3", "Index on CZDOCO, CZDCTO, CZKCOO, CZLNID, CZEDUS", new[] { "CZDOCO", "CZDCTO", "CZKCOO", "CZLNID", "CZEDUS" })
    };
}
