using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L100 - .
/// </summary>
public class F15L100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCMCU.
        /// </summary>
        public const string BCMCU = "BCMCU";

        /// <summary>
        /// BCRVNB.
        /// </summary>
        public const string BCRVNB = "BCRVNB";

        /// <summary>
        /// BCEPRD.
        /// </summary>
        public const string BCEPRD = "BCEPRD";

        /// <summary>
        /// BCASSD.
        /// </summary>
        public const string BCASSD = "BCASSD";

        /// <summary>
        /// BCSOID.
        /// </summary>
        public const string BCSOID = "BCSOID";

        /// <summary>
        /// BCBCRI.
        /// </summary>
        public const string BCBCRI = "BCBCRI";

        /// <summary>
        /// BCUDGP.
        /// </summary>
        public const string BCUDGP = "BCUDGP";

        /// <summary>
        /// BCAIPP.
        /// </summary>
        public const string BCAIPP = "BCAIPP";

        /// <summary>
        /// BCACPE.
        /// </summary>
        public const string BCACPE = "BCACPE";

        /// <summary>
        /// BCADPE.
        /// </summary>
        public const string BCADPE = "BCADPE";

        /// <summary>
        /// BCASPE.
        /// </summary>
        public const string BCASPE = "BCASPE";

        /// <summary>
        /// BCASCA.
        /// </summary>
        public const string BCASCA = "BCASCA";

        /// <summary>
        /// BCANPV.
        /// </summary>
        public const string BCANPV = "BCANPV";

        /// <summary>
        /// BCANPB.
        /// </summary>
        public const string BCANPB = "BCANPB";

        /// <summary>
        /// BCIRRN.
        /// </summary>
        public const string BCIRRN = "BCIRRN";

        /// <summary>
        /// BCIRRB.
        /// </summary>
        public const string BCIRRB = "BCIRRB";

        /// <summary>
        /// BCABSP.
        /// </summary>
        public const string BCABSP = "BCABSP";

        /// <summary>
        /// BCNPFS.
        /// </summary>
        public const string BCNPFS = "BCNPFS";

        /// <summary>
        /// BCAYSN.
        /// </summary>
        public const string BCAYSN = "BCAYSN";

        /// <summary>
        /// BCANOI.
        /// </summary>
        public const string BCANOI = "BCANOI";

        /// <summary>
        /// BCATMP.
        /// </summary>
        public const string BCATMP = "BCATMP";

        /// <summary>
        /// BCATPT.
        /// </summary>
        public const string BCATPT = "BCATPT";

        /// <summary>
        /// BCARAC.
        /// </summary>
        public const string BCARAC = "BCARAC";

        /// <summary>
        /// BCXPCT.
        /// </summary>
        public const string BCXPCT = "BCXPCT";

        /// <summary>
        /// BCGLC.
        /// </summary>
        public const string BCGLC = "BCGLC";

        /// <summary>
        /// BCGLC3.
        /// </summary>
        public const string BCGLC3 = "BCGLC3";

        /// <summary>
        /// BCFERT.
        /// </summary>
        public const string BCFERT = "BCFERT";

        /// <summary>
        /// BCMIND.
        /// </summary>
        public const string BCMIND = "BCMIND";

        /// <summary>
        /// BCDMAX.
        /// </summary>
        public const string BCDMAX = "BCDMAX";

        /// <summary>
        /// BCURCD.
        /// </summary>
        public const string BCURCD = "BCURCD";

        /// <summary>
        /// BCURDT.
        /// </summary>
        public const string BCURDT = "BCURDT";

        /// <summary>
        /// BCURAT.
        /// </summary>
        public const string BCURAT = "BCURAT";

        /// <summary>
        /// BCURAB.
        /// </summary>
        public const string BCURAB = "BCURAB";

        /// <summary>
        /// BCURRF.
        /// </summary>
        public const string BCURRF = "BCURRF";

        /// <summary>
        /// BCTORG.
        /// </summary>
        public const string BCTORG = "BCTORG";

        /// <summary>
        /// BCENTJ.
        /// </summary>
        public const string BCENTJ = "BCENTJ";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCUPMT.
        /// </summary>
        public const string BCUPMT = "BCUPMT";

        /// <summary>
        /// BCOPFL.
        /// </summary>
        public const string BCOPFL = "BCOPFL";

        /// <summary>
        /// BCAACT.
        /// </summary>
        public const string BCAACT = "BCAACT";

        /// <summary>
        /// BCARRID.
        /// </summary>
        public const string BCARRID = "BCARRID";

        /// <summary>
        /// BCRONLY.
        /// </summary>
        public const string BCRONLY = "BCRONLY";
    }

    /// <inheritdoc />
    public override string TableName => "F15L100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCMCU", "BCMCU", JdeDataType.String, 24, true, true),
        new JdeField("BCRVNB", "BCRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("BCEPRD", "BCEPRD", JdeDataType.String, 20),
        new JdeField("BCASSD", "BCASSD", JdeDataType.String, 20),
        new JdeField("BCSOID", "BCSOID", JdeDataType.String, 20),
        new JdeField("BCBCRI", "BCBCRI", JdeDataType.String, 20),
        new JdeField("BCUDGP", "BCUDGP", JdeDataType.String, 20),
        new JdeField("BCAIPP", "BCAIPP", JdeDataType.Numeric),
        new JdeField("BCACPE", "BCACPE", JdeDataType.Numeric),
        new JdeField("BCADPE", "BCADPE", JdeDataType.Numeric),
        new JdeField("BCASPE", "BCASPE", JdeDataType.Numeric),
        new JdeField("BCASCA", "BCASCA", JdeDataType.Numeric),
        new JdeField("BCANPV", "BCANPV", JdeDataType.Numeric),
        new JdeField("BCANPB", "BCANPB", JdeDataType.String, 8),
        new JdeField("BCIRRN", "BCIRRN", JdeDataType.Numeric),
        new JdeField("BCIRRB", "BCIRRB", JdeDataType.String, 8),
        new JdeField("BCABSP", "BCABSP", JdeDataType.Numeric),
        new JdeField("BCNPFS", "BCNPFS", JdeDataType.Numeric),
        new JdeField("BCAYSN", "BCAYSN", JdeDataType.Numeric),
        new JdeField("BCANOI", "BCANOI", JdeDataType.Numeric),
        new JdeField("BCATMP", "BCATMP", JdeDataType.Numeric),
        new JdeField("BCATPT", "BCATPT", JdeDataType.String, 4),
        new JdeField("BCARAC", "BCARAC", JdeDataType.String, 8),
        new JdeField("BCXPCT", "BCXPCT", JdeDataType.Numeric),
        new JdeField("BCGLC", "BCGLC", JdeDataType.String, 8),
        new JdeField("BCGLC3", "BCGLC3", JdeDataType.String, 8),
        new JdeField("BCFERT", "BCFERT", JdeDataType.Numeric),
        new JdeField("BCMIND", "BCMIND", JdeDataType.Numeric),
        new JdeField("BCDMAX", "BCDMAX", JdeDataType.Numeric),
        new JdeField("BCURCD", "BCURCD", JdeDataType.String, 4),
        new JdeField("BCURDT", "BCURDT", JdeDataType.Numeric),
        new JdeField("BCURAT", "BCURAT", JdeDataType.Numeric),
        new JdeField("BCURAB", "BCURAB", JdeDataType.Numeric),
        new JdeField("BCURRF", "BCURRF", JdeDataType.String, 30),
        new JdeField("BCTORG", "BCTORG", JdeDataType.String, 20),
        new JdeField("BCENTJ", "BCENTJ", JdeDataType.Numeric),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCUPMT", "BCUPMT", JdeDataType.Numeric),
        new JdeField("BCOPFL", "BCOPFL", JdeDataType.String, 2),
        new JdeField("BCAACT", "BCAACT", JdeDataType.String, 4),
        new JdeField("BCARRID", "BCARRID", JdeDataType.String, 20),
        new JdeField("BCRONLY", "BCRONLY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L100_0", "Primary Key on BCMCU, BCRVNB", new[] { "BCMCU", "BCRVNB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L100_2", "Index on BCARRID", new[] { "BCARRID" }),
        new JdeIndex("F15L100_3", "Index on BCMCU, BCRVNB, BCARRID", new[] { "BCMCU", "BCRVNB", "BCARRID" })
    };
}
