using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47171 - .
/// </summary>
public class F47171 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHEDTY.
        /// </summary>
        public const string EHEDTY = "EHEDTY";

        /// <summary>
        /// EHEDSQ.
        /// </summary>
        public const string EHEDSQ = "EHEDSQ";

        /// <summary>
        /// EHEKCO.
        /// </summary>
        public const string EHEKCO = "EHEKCO";

        /// <summary>
        /// EHEDOC.
        /// </summary>
        public const string EHEDOC = "EHEDOC";

        /// <summary>
        /// EHEDCT.
        /// </summary>
        public const string EHEDCT = "EHEDCT";

        /// <summary>
        /// EHEDLN.
        /// </summary>
        public const string EHEDLN = "EHEDLN";

        /// <summary>
        /// EHEDST.
        /// </summary>
        public const string EHEDST = "EHEDST";

        /// <summary>
        /// EHEDFT.
        /// </summary>
        public const string EHEDFT = "EHEDFT";

        /// <summary>
        /// EHEDDT.
        /// </summary>
        public const string EHEDDT = "EHEDDT";

        /// <summary>
        /// EHEDER.
        /// </summary>
        public const string EHEDER = "EHEDER";

        /// <summary>
        /// EHEDDL.
        /// </summary>
        public const string EHEDDL = "EHEDDL";

        /// <summary>
        /// EHEDSP.
        /// </summary>
        public const string EHEDSP = "EHEDSP";

        /// <summary>
        /// EHEDBT.
        /// </summary>
        public const string EHEDBT = "EHEDBT";

        /// <summary>
        /// EHMCU.
        /// </summary>
        public const string EHMCU = "EHMCU";

        /// <summary>
        /// EHAN8.
        /// </summary>
        public const string EHAN8 = "EHAN8";

        /// <summary>
        /// EHSHAN.
        /// </summary>
        public const string EHSHAN = "EHSHAN";

        /// <summary>
        /// EHTPUR.
        /// </summary>
        public const string EHTPUR = "EHTPUR";

        /// <summary>
        /// EHTXTREFNO.
        /// </summary>
        public const string EHTXTREFNO = "EHTXTREFNO";

        /// <summary>
        /// EHRLSNO.
        /// </summary>
        public const string EHRLSNO = "EHRLSNO";

        /// <summary>
        /// EHRLSDJ.
        /// </summary>
        public const string EHRLSDJ = "EHRLSDJ";

        /// <summary>
        /// EHRLSTM.
        /// </summary>
        public const string EHRLSTM = "EHRLSTM";

        /// <summary>
        /// EHHZSD.
        /// </summary>
        public const string EHHZSD = "EHHZSD";

        /// <summary>
        /// EHHZED.
        /// </summary>
        public const string EHHZED = "EHHZED";

        /// <summary>
        /// EHEDTCTDJ.
        /// </summary>
        public const string EHEDTCTDJ = "EHEDTCTDJ";

        /// <summary>
        /// EHEDTCTTM.
        /// </summary>
        public const string EHEDTCTTM = "EHEDTCTTM";

        /// <summary>
        /// EHEDTMSGNM.
        /// </summary>
        public const string EHEDTMSGNM = "EHEDTMSGNM";

        /// <summary>
        /// EHEDTMSGSB.
        /// </summary>
        public const string EHEDTMSGSB = "EHEDTMSGSB";

        /// <summary>
        /// EHEDTMSGTP.
        /// </summary>
        public const string EHEDTMSGTP = "EHEDTMSGTP";

        /// <summary>
        /// EHSUCREPST.
        /// </summary>
        public const string EHSUCREPST = "EHSUCREPST";

        /// <summary>
        /// EHURCD.
        /// </summary>
        public const string EHURCD = "EHURCD";

        /// <summary>
        /// EHURDT.
        /// </summary>
        public const string EHURDT = "EHURDT";

        /// <summary>
        /// EHURAT.
        /// </summary>
        public const string EHURAT = "EHURAT";

        /// <summary>
        /// EHURAB.
        /// </summary>
        public const string EHURAB = "EHURAB";

        /// <summary>
        /// EHURRF.
        /// </summary>
        public const string EHURRF = "EHURRF";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHJOBN.
        /// </summary>
        public const string EHJOBN = "EHJOBN";

        /// <summary>
        /// EHUPMJ.
        /// </summary>
        public const string EHUPMJ = "EHUPMJ";

        /// <summary>
        /// EHTDAY.
        /// </summary>
        public const string EHTDAY = "EHTDAY";

        /// <summary>
        /// EHGAN8.
        /// </summary>
        public const string EHGAN8 = "EHGAN8";

        /// <summary>
        /// EHGSHAN.
        /// </summary>
        public const string EHGSHAN = "EHGSHAN";
    }

    /// <inheritdoc />
    public override string TableName => "F47171";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHEDTY", "EHEDTY", JdeDataType.String, 2),
        new JdeField("EHEDSQ", "EHEDSQ", JdeDataType.Numeric),
        new JdeField("EHEKCO", "EHEKCO", JdeDataType.String, 10, true, true),
        new JdeField("EHEDOC", "EHEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("EHEDCT", "EHEDCT", JdeDataType.String, 4, true, true),
        new JdeField("EHEDLN", "EHEDLN", JdeDataType.Numeric),
        new JdeField("EHEDST", "EHEDST", JdeDataType.String, 12),
        new JdeField("EHEDFT", "EHEDFT", JdeDataType.String, 20),
        new JdeField("EHEDDT", "EHEDDT", JdeDataType.Numeric),
        new JdeField("EHEDER", "EHEDER", JdeDataType.String, 2),
        new JdeField("EHEDDL", "EHEDDL", JdeDataType.Numeric),
        new JdeField("EHEDSP", "EHEDSP", JdeDataType.String, 2),
        new JdeField("EHEDBT", "EHEDBT", JdeDataType.String, 30),
        new JdeField("EHMCU", "EHMCU", JdeDataType.String, 24),
        new JdeField("EHAN8", "EHAN8", JdeDataType.Numeric),
        new JdeField("EHSHAN", "EHSHAN", JdeDataType.Numeric),
        new JdeField("EHTPUR", "EHTPUR", JdeDataType.String, 4),
        new JdeField("EHTXTREFNO", "EHTXTREFNO", JdeDataType.String, 30),
        new JdeField("EHRLSNO", "EHRLSNO", JdeDataType.String, 20),
        new JdeField("EHRLSDJ", "EHRLSDJ", JdeDataType.Numeric),
        new JdeField("EHRLSTM", "EHRLSTM", JdeDataType.Numeric),
        new JdeField("EHHZSD", "EHHZSD", JdeDataType.Numeric),
        new JdeField("EHHZED", "EHHZED", JdeDataType.Numeric),
        new JdeField("EHEDTCTDJ", "EHEDTCTDJ", JdeDataType.Numeric),
        new JdeField("EHEDTCTTM", "EHEDTCTTM", JdeDataType.Numeric),
        new JdeField("EHEDTMSGNM", "EHEDTMSGNM", JdeDataType.String, 20),
        new JdeField("EHEDTMSGSB", "EHEDTMSGSB", JdeDataType.String, 6),
        new JdeField("EHEDTMSGTP", "EHEDTMSGTP", JdeDataType.String, 6),
        new JdeField("EHSUCREPST", "EHSUCREPST", JdeDataType.String, 2),
        new JdeField("EHURCD", "EHURCD", JdeDataType.String, 4),
        new JdeField("EHURDT", "EHURDT", JdeDataType.Numeric),
        new JdeField("EHURAT", "EHURAT", JdeDataType.Numeric),
        new JdeField("EHURAB", "EHURAB", JdeDataType.Numeric),
        new JdeField("EHURRF", "EHURRF", JdeDataType.String, 30),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHJOBN", "EHJOBN", JdeDataType.String, 20),
        new JdeField("EHUPMJ", "EHUPMJ", JdeDataType.Numeric),
        new JdeField("EHTDAY", "EHTDAY", JdeDataType.Numeric),
        new JdeField("EHGAN8", "EHGAN8", JdeDataType.Numeric),
        new JdeField("EHGSHAN", "EHGSHAN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47171_0", "Primary Key on EHEKCO, EHEDOC, EHEDCT", new[] { "EHEKCO", "EHEDOC", "EHEDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
