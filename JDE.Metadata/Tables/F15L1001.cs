using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L1001 - .
/// </summary>
public class F15L1001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BMBMCI.
        /// </summary>
        public const string BMBMCI = "BMBMCI";

        /// <summary>
        /// BMDL01.
        /// </summary>
        public const string BMDL01 = "BMDL01";

        /// <summary>
        /// BMEPRD.
        /// </summary>
        public const string BMEPRD = "BMEPRD";

        /// <summary>
        /// BMASSD.
        /// </summary>
        public const string BMASSD = "BMASSD";

        /// <summary>
        /// BMSOID.
        /// </summary>
        public const string BMSOID = "BMSOID";

        /// <summary>
        /// BMBCRI.
        /// </summary>
        public const string BMBCRI = "BMBCRI";

        /// <summary>
        /// BMUDGP.
        /// </summary>
        public const string BMUDGP = "BMUDGP";

        /// <summary>
        /// BMAIPP.
        /// </summary>
        public const string BMAIPP = "BMAIPP";

        /// <summary>
        /// BMACPE.
        /// </summary>
        public const string BMACPE = "BMACPE";

        /// <summary>
        /// BMADPE.
        /// </summary>
        public const string BMADPE = "BMADPE";

        /// <summary>
        /// BMASPE.
        /// </summary>
        public const string BMASPE = "BMASPE";

        /// <summary>
        /// BMASCA.
        /// </summary>
        public const string BMASCA = "BMASCA";

        /// <summary>
        /// BMANPV.
        /// </summary>
        public const string BMANPV = "BMANPV";

        /// <summary>
        /// BMANPB.
        /// </summary>
        public const string BMANPB = "BMANPB";

        /// <summary>
        /// BMIRRN.
        /// </summary>
        public const string BMIRRN = "BMIRRN";

        /// <summary>
        /// BMIRRB.
        /// </summary>
        public const string BMIRRB = "BMIRRB";

        /// <summary>
        /// BMABSP.
        /// </summary>
        public const string BMABSP = "BMABSP";

        /// <summary>
        /// BMNPFS.
        /// </summary>
        public const string BMNPFS = "BMNPFS";

        /// <summary>
        /// BMAYSN.
        /// </summary>
        public const string BMAYSN = "BMAYSN";

        /// <summary>
        /// BMANOI.
        /// </summary>
        public const string BMANOI = "BMANOI";

        /// <summary>
        /// BMATMP.
        /// </summary>
        public const string BMATMP = "BMATMP";

        /// <summary>
        /// BMATPT.
        /// </summary>
        public const string BMATPT = "BMATPT";

        /// <summary>
        /// BMARAC.
        /// </summary>
        public const string BMARAC = "BMARAC";

        /// <summary>
        /// BMXPCT.
        /// </summary>
        public const string BMXPCT = "BMXPCT";

        /// <summary>
        /// BMGLC.
        /// </summary>
        public const string BMGLC = "BMGLC";

        /// <summary>
        /// BMGLC3.
        /// </summary>
        public const string BMGLC3 = "BMGLC3";

        /// <summary>
        /// BMFERT.
        /// </summary>
        public const string BMFERT = "BMFERT";

        /// <summary>
        /// BMMIND.
        /// </summary>
        public const string BMMIND = "BMMIND";

        /// <summary>
        /// BMDMAX.
        /// </summary>
        public const string BMDMAX = "BMDMAX";

        /// <summary>
        /// BMURCD.
        /// </summary>
        public const string BMURCD = "BMURCD";

        /// <summary>
        /// BMURDT.
        /// </summary>
        public const string BMURDT = "BMURDT";

        /// <summary>
        /// BMURAT.
        /// </summary>
        public const string BMURAT = "BMURAT";

        /// <summary>
        /// BMURAB.
        /// </summary>
        public const string BMURAB = "BMURAB";

        /// <summary>
        /// BMURRF.
        /// </summary>
        public const string BMURRF = "BMURRF";

        /// <summary>
        /// BMTORG.
        /// </summary>
        public const string BMTORG = "BMTORG";

        /// <summary>
        /// BMENTJ.
        /// </summary>
        public const string BMENTJ = "BMENTJ";

        /// <summary>
        /// BMJOBN.
        /// </summary>
        public const string BMJOBN = "BMJOBN";

        /// <summary>
        /// BMUSER.
        /// </summary>
        public const string BMUSER = "BMUSER";

        /// <summary>
        /// BMPID.
        /// </summary>
        public const string BMPID = "BMPID";

        /// <summary>
        /// BMUPMJ.
        /// </summary>
        public const string BMUPMJ = "BMUPMJ";

        /// <summary>
        /// BMUPMT.
        /// </summary>
        public const string BMUPMT = "BMUPMT";

        /// <summary>
        /// BMOPFL.
        /// </summary>
        public const string BMOPFL = "BMOPFL";

        /// <summary>
        /// BMAACT.
        /// </summary>
        public const string BMAACT = "BMAACT";

        /// <summary>
        /// BMARRID.
        /// </summary>
        public const string BMARRID = "BMARRID";

        /// <summary>
        /// BMRONLY.
        /// </summary>
        public const string BMRONLY = "BMRONLY";
    }

    /// <inheritdoc />
    public override string TableName => "F15L1001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BMBMCI", "BMBMCI", JdeDataType.String, 24, true, true),
        new JdeField("BMDL01", "BMDL01", JdeDataType.String, 60),
        new JdeField("BMEPRD", "BMEPRD", JdeDataType.String, 20),
        new JdeField("BMASSD", "BMASSD", JdeDataType.String, 20),
        new JdeField("BMSOID", "BMSOID", JdeDataType.String, 20),
        new JdeField("BMBCRI", "BMBCRI", JdeDataType.String, 20),
        new JdeField("BMUDGP", "BMUDGP", JdeDataType.String, 20),
        new JdeField("BMAIPP", "BMAIPP", JdeDataType.Numeric),
        new JdeField("BMACPE", "BMACPE", JdeDataType.Numeric),
        new JdeField("BMADPE", "BMADPE", JdeDataType.Numeric),
        new JdeField("BMASPE", "BMASPE", JdeDataType.Numeric),
        new JdeField("BMASCA", "BMASCA", JdeDataType.Numeric),
        new JdeField("BMANPV", "BMANPV", JdeDataType.Numeric),
        new JdeField("BMANPB", "BMANPB", JdeDataType.String, 8),
        new JdeField("BMIRRN", "BMIRRN", JdeDataType.Numeric),
        new JdeField("BMIRRB", "BMIRRB", JdeDataType.String, 8),
        new JdeField("BMABSP", "BMABSP", JdeDataType.Numeric),
        new JdeField("BMNPFS", "BMNPFS", JdeDataType.Numeric),
        new JdeField("BMAYSN", "BMAYSN", JdeDataType.Numeric),
        new JdeField("BMANOI", "BMANOI", JdeDataType.Numeric),
        new JdeField("BMATMP", "BMATMP", JdeDataType.Numeric),
        new JdeField("BMATPT", "BMATPT", JdeDataType.String, 4),
        new JdeField("BMARAC", "BMARAC", JdeDataType.String, 8),
        new JdeField("BMXPCT", "BMXPCT", JdeDataType.Numeric),
        new JdeField("BMGLC", "BMGLC", JdeDataType.String, 8),
        new JdeField("BMGLC3", "BMGLC3", JdeDataType.String, 8),
        new JdeField("BMFERT", "BMFERT", JdeDataType.Numeric),
        new JdeField("BMMIND", "BMMIND", JdeDataType.Numeric),
        new JdeField("BMDMAX", "BMDMAX", JdeDataType.Numeric),
        new JdeField("BMURCD", "BMURCD", JdeDataType.String, 4),
        new JdeField("BMURDT", "BMURDT", JdeDataType.Numeric),
        new JdeField("BMURAT", "BMURAT", JdeDataType.Numeric),
        new JdeField("BMURAB", "BMURAB", JdeDataType.Numeric),
        new JdeField("BMURRF", "BMURRF", JdeDataType.String, 30),
        new JdeField("BMTORG", "BMTORG", JdeDataType.String, 20),
        new JdeField("BMENTJ", "BMENTJ", JdeDataType.Numeric),
        new JdeField("BMJOBN", "BMJOBN", JdeDataType.String, 20),
        new JdeField("BMUSER", "BMUSER", JdeDataType.String, 20),
        new JdeField("BMPID", "BMPID", JdeDataType.String, 20),
        new JdeField("BMUPMJ", "BMUPMJ", JdeDataType.Numeric),
        new JdeField("BMUPMT", "BMUPMT", JdeDataType.Numeric),
        new JdeField("BMOPFL", "BMOPFL", JdeDataType.String, 2),
        new JdeField("BMAACT", "BMAACT", JdeDataType.String, 4),
        new JdeField("BMARRID", "BMARRID", JdeDataType.String, 20),
        new JdeField("BMRONLY", "BMRONLY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L1001_0", "Primary Key on BMBMCI", new[] { "BMBMCI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L1001_2", "Index on BMARRID", new[] { "BMARRID" })
    };
}
