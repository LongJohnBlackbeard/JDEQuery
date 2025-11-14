using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42A012 - .
/// </summary>
public class F42A012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OPOPPN.
        /// </summary>
        public const string OPOPPN = "OPOPPN";

        /// <summary>
        /// OPOPDE.
        /// </summary>
        public const string OPOPDE = "OPOPDE";

        /// <summary>
        /// OPCANM.
        /// </summary>
        public const string OPCANM = "OPCANM";

        /// <summary>
        /// OPCPNO.
        /// </summary>
        public const string OPCPNO = "OPCPNO";

        /// <summary>
        /// OPCURS.
        /// </summary>
        public const string OPCURS = "OPCURS";

        /// <summary>
        /// OPOTCD.
        /// </summary>
        public const string OPOTCD = "OPOTCD";

        /// <summary>
        /// OPOREA.
        /// </summary>
        public const string OPOREA = "OPOREA";

        /// <summary>
        /// OPPCPT.
        /// </summary>
        public const string OPPCPT = "OPPCPT";

        /// <summary>
        /// OPECDT.
        /// </summary>
        public const string OPECDT = "OPECDT";

        /// <summary>
        /// OPCRCD.
        /// </summary>
        public const string OPCRCD = "OPCRCD";

        /// <summary>
        /// OPRTGT.
        /// </summary>
        public const string OPRTGT = "OPRTGT";

        /// <summary>
        /// OPCRSP.
        /// </summary>
        public const string OPCRSP = "OPCRSP";

        /// <summary>
        /// OPCRNS.
        /// </summary>
        public const string OPCRNS = "OPCRNS";

        /// <summary>
        /// OPCARQ.
        /// </summary>
        public const string OPCARQ = "OPCARQ";

        /// <summary>
        /// OPPCL1.
        /// </summary>
        public const string OPPCL1 = "OPPCL1";

        /// <summary>
        /// OPPCL2.
        /// </summary>
        public const string OPPCL2 = "OPPCL2";

        /// <summary>
        /// OPLSRC.
        /// </summary>
        public const string OPLSRC = "OPLSRC";

        /// <summary>
        /// OPLSTY.
        /// </summary>
        public const string OPLSTY = "OPLSTY";

        /// <summary>
        /// OPTRDT.
        /// </summary>
        public const string OPTRDT = "OPTRDT";

        /// <summary>
        /// OPTERI.
        /// </summary>
        public const string OPTERI = "OPTERI";

        /// <summary>
        /// OPOPC1.
        /// </summary>
        public const string OPOPC1 = "OPOPC1";

        /// <summary>
        /// OPOPC2.
        /// </summary>
        public const string OPOPC2 = "OPOPC2";

        /// <summary>
        /// OPOPC3.
        /// </summary>
        public const string OPOPC3 = "OPOPC3";

        /// <summary>
        /// OPOPC4.
        /// </summary>
        public const string OPOPC4 = "OPOPC4";

        /// <summary>
        /// OPOPC5.
        /// </summary>
        public const string OPOPC5 = "OPOPC5";

        /// <summary>
        /// OPOY01.
        /// </summary>
        public const string OPOY01 = "OPOY01";

        /// <summary>
        /// OPOY02.
        /// </summary>
        public const string OPOY02 = "OPOY02";

        /// <summary>
        /// OPOY03.
        /// </summary>
        public const string OPOY03 = "OPOY03";

        /// <summary>
        /// OPOY04.
        /// </summary>
        public const string OPOY04 = "OPOY04";

        /// <summary>
        /// OPOY05.
        /// </summary>
        public const string OPOY05 = "OPOY05";

        /// <summary>
        /// OPRNPF.
        /// </summary>
        public const string OPRNPF = "OPRNPF";

        /// <summary>
        /// OPRVPL.
        /// </summary>
        public const string OPRVPL = "OPRVPL";

        /// <summary>
        /// OPTRFP.
        /// </summary>
        public const string OPTRFP = "OPTRFP";

        /// <summary>
        /// OPURAB.
        /// </summary>
        public const string OPURAB = "OPURAB";

        /// <summary>
        /// OPURAT.
        /// </summary>
        public const string OPURAT = "OPURAT";

        /// <summary>
        /// OPURCD.
        /// </summary>
        public const string OPURCD = "OPURCD";

        /// <summary>
        /// OPURDT.
        /// </summary>
        public const string OPURDT = "OPURDT";

        /// <summary>
        /// OPURRF.
        /// </summary>
        public const string OPURRF = "OPURRF";

        /// <summary>
        /// OPUSER.
        /// </summary>
        public const string OPUSER = "OPUSER";

        /// <summary>
        /// OPPID.
        /// </summary>
        public const string OPPID = "OPPID";

        /// <summary>
        /// OPCTID.
        /// </summary>
        public const string OPCTID = "OPCTID";

        /// <summary>
        /// OPUPMJ.
        /// </summary>
        public const string OPUPMJ = "OPUPMJ";

        /// <summary>
        /// OPUPMT.
        /// </summary>
        public const string OPUPMT = "OPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F42A012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OPOPPN", "OPOPPN", JdeDataType.Numeric, null, true, true),
        new JdeField("OPOPDE", "OPOPDE", JdeDataType.String, 80),
        new JdeField("OPCANM", "OPCANM", JdeDataType.Numeric),
        new JdeField("OPCPNO", "OPCPNO", JdeDataType.Numeric),
        new JdeField("OPCURS", "OPCURS", JdeDataType.String, 6),
        new JdeField("OPOTCD", "OPOTCD", JdeDataType.String, 10),
        new JdeField("OPOREA", "OPOREA", JdeDataType.String, 10),
        new JdeField("OPPCPT", "OPPCPT", JdeDataType.Numeric),
        new JdeField("OPECDT", "OPECDT", JdeDataType.Numeric),
        new JdeField("OPCRCD", "OPCRCD", JdeDataType.String, 6),
        new JdeField("OPRTGT", "OPRTGT", JdeDataType.Numeric),
        new JdeField("OPCRSP", "OPCRSP", JdeDataType.Numeric),
        new JdeField("OPCRNS", "OPCRNS", JdeDataType.Numeric),
        new JdeField("OPCARQ", "OPCARQ", JdeDataType.Numeric),
        new JdeField("OPPCL1", "OPPCL1", JdeDataType.String, 10),
        new JdeField("OPPCL2", "OPPCL2", JdeDataType.String, 10),
        new JdeField("OPLSRC", "OPLSRC", JdeDataType.String, 80),
        new JdeField("OPLSTY", "OPLSTY", JdeDataType.String, 80),
        new JdeField("OPTRDT", "OPTRDT", JdeDataType.Numeric),
        new JdeField("OPTERI", "OPTERI", JdeDataType.String, 10),
        new JdeField("OPOPC1", "OPOPC1", JdeDataType.String, 6),
        new JdeField("OPOPC2", "OPOPC2", JdeDataType.String, 6),
        new JdeField("OPOPC3", "OPOPC3", JdeDataType.String, 6),
        new JdeField("OPOPC4", "OPOPC4", JdeDataType.String, 6),
        new JdeField("OPOPC5", "OPOPC5", JdeDataType.String, 6),
        new JdeField("OPOY01", "OPOY01", JdeDataType.String, 6),
        new JdeField("OPOY02", "OPOY02", JdeDataType.String, 6),
        new JdeField("OPOY03", "OPOY03", JdeDataType.String, 6),
        new JdeField("OPOY04", "OPOY04", JdeDataType.String, 6),
        new JdeField("OPOY05", "OPOY05", JdeDataType.String, 6),
        new JdeField("OPRNPF", "OPRNPF", JdeDataType.Numeric),
        new JdeField("OPRVPL", "OPRVPL", JdeDataType.Numeric),
        new JdeField("OPTRFP", "OPTRFP", JdeDataType.Numeric),
        new JdeField("OPURAB", "OPURAB", JdeDataType.Numeric),
        new JdeField("OPURAT", "OPURAT", JdeDataType.Numeric),
        new JdeField("OPURCD", "OPURCD", JdeDataType.String, 4),
        new JdeField("OPURDT", "OPURDT", JdeDataType.Numeric),
        new JdeField("OPURRF", "OPURRF", JdeDataType.String, 30),
        new JdeField("OPUSER", "OPUSER", JdeDataType.String, 20),
        new JdeField("OPPID", "OPPID", JdeDataType.String, 20),
        new JdeField("OPCTID", "OPCTID", JdeDataType.String, 30),
        new JdeField("OPUPMJ", "OPUPMJ", JdeDataType.Numeric),
        new JdeField("OPUPMT", "OPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42A012_0", "Primary Key on OPOPPN", new[] { "OPOPPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42A012_2", "Index on OPOPPN, OPCANM", new[] { "OPOPPN", "OPCANM" }),
        new JdeIndex("F42A012_3", "Index on OPCANM", new[] { "OPCANM" })
    };
}
