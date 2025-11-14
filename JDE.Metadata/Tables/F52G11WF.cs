using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G11WF - .
/// </summary>
public class F52G11WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BWDCT.
        /// </summary>
        public const string BWDCT = "BWDCT";

        /// <summary>
        /// BWDOC.
        /// </summary>
        public const string BWDOC = "BWDOC";

        /// <summary>
        /// BWKCO.
        /// </summary>
        public const string BWKCO = "BWKCO";

        /// <summary>
        /// BWDGJ.
        /// </summary>
        public const string BWDGJ = "BWDGJ";

        /// <summary>
        /// BWJELN.
        /// </summary>
        public const string BWJELN = "BWJELN";

        /// <summary>
        /// BWLT.
        /// </summary>
        public const string BWLT = "BWLT";

        /// <summary>
        /// BWEXTL.
        /// </summary>
        public const string BWEXTL = "BWEXTL";

        /// <summary>
        /// BWBUCA.
        /// </summary>
        public const string BWBUCA = "BWBUCA";

        /// <summary>
        /// BWCO.
        /// </summary>
        public const string BWCO = "BWCO";

        /// <summary>
        /// BWMCU.
        /// </summary>
        public const string BWMCU = "BWMCU";

        /// <summary>
        /// BWOBJ.
        /// </summary>
        public const string BWOBJ = "BWOBJ";

        /// <summary>
        /// BWSUB.
        /// </summary>
        public const string BWSUB = "BWSUB";

        /// <summary>
        /// BWSBL.
        /// </summary>
        public const string BWSBL = "BWSBL";

        /// <summary>
        /// BWSBLT.
        /// </summary>
        public const string BWSBLT = "BWSBLT";

        /// <summary>
        /// BWANI.
        /// </summary>
        public const string BWANI = "BWANI";

        /// <summary>
        /// BWAID.
        /// </summary>
        public const string BWAID = "BWAID";

        /// <summary>
        /// BWPN.
        /// </summary>
        public const string BWPN = "BWPN";

        /// <summary>
        /// BWCTRY.
        /// </summary>
        public const string BWCTRY = "BWCTRY";

        /// <summary>
        /// BWFY.
        /// </summary>
        public const string BWFY = "BWFY";

        /// <summary>
        /// BWCRCD.
        /// </summary>
        public const string BWCRCD = "BWCRCD";

        /// <summary>
        /// BWU.
        /// </summary>
        public const string BWU = "BWU";

        /// <summary>
        /// BWAA.
        /// </summary>
        public const string BWAA = "BWAA";

        /// <summary>
        /// BWAA3.
        /// </summary>
        public const string BWAA3 = "BWAA3";

        /// <summary>
        /// BWITOL.
        /// </summary>
        public const string BWITOL = "BWITOL";

        /// <summary>
        /// BWBTOL.
        /// </summary>
        public const string BWBTOL = "BWBTOL";

        /// <summary>
        /// BWEXA.
        /// </summary>
        public const string BWEXA = "BWEXA";

        /// <summary>
        /// BWEXR.
        /// </summary>
        public const string BWEXR = "BWEXR";

        /// <summary>
        /// BWAN8.
        /// </summary>
        public const string BWAN8 = "BWAN8";

        /// <summary>
        /// BWAHBU.
        /// </summary>
        public const string BWAHBU = "BWAHBU";

        /// <summary>
        /// BWEPGC.
        /// </summary>
        public const string BWEPGC = "BWEPGC";

        /// <summary>
        /// BWJBCD.
        /// </summary>
        public const string BWJBCD = "BWJBCD";

        /// <summary>
        /// BWJBST.
        /// </summary>
        public const string BWJBST = "BWJBST";

        /// <summary>
        /// BWJPGC.
        /// </summary>
        public const string BWJPGC = "BWJPGC";

        /// <summary>
        /// BWSEGMID.
        /// </summary>
        public const string BWSEGMID = "BWSEGMID";

        /// <summary>
        /// BWPOOLID.
        /// </summary>
        public const string BWPOOLID = "BWPOOLID";

        /// <summary>
        /// BWDSVJ.
        /// </summary>
        public const string BWDSVJ = "BWDSVJ";

        /// <summary>
        /// BWBC.
        /// </summary>
        public const string BWBC = "BWBC";

        /// <summary>
        /// BWAID5.
        /// </summary>
        public const string BWAID5 = "BWAID5";

        /// <summary>
        /// BWAID6.
        /// </summary>
        public const string BWAID6 = "BWAID6";

        /// <summary>
        /// BWRAS.
        /// </summary>
        public const string BWRAS = "BWRAS";

        /// <summary>
        /// BWRAG.
        /// </summary>
        public const string BWRAG = "BWRAG";

        /// <summary>
        /// BWCTF4.
        /// </summary>
        public const string BWCTF4 = "BWCTF4";

        /// <summary>
        /// BWGPF1.
        /// </summary>
        public const string BWGPF1 = "BWGPF1";

        /// <summary>
        /// BWFFU3.
        /// </summary>
        public const string BWFFU3 = "BWFFU3";

        /// <summary>
        /// BWTXF1.
        /// </summary>
        public const string BWTXF1 = "BWTXF1";

        /// <summary>
        /// BWPID.
        /// </summary>
        public const string BWPID = "BWPID";

        /// <summary>
        /// BWMKEY.
        /// </summary>
        public const string BWMKEY = "BWMKEY";

        /// <summary>
        /// BWUSER.
        /// </summary>
        public const string BWUSER = "BWUSER";

        /// <summary>
        /// BWUPMJ.
        /// </summary>
        public const string BWUPMJ = "BWUPMJ";

        /// <summary>
        /// BWUPMT.
        /// </summary>
        public const string BWUPMT = "BWUPMT";

        /// <summary>
        /// BWJOBS.
        /// </summary>
        public const string BWJOBS = "BWJOBS";

        /// <summary>
        /// BWLNID.
        /// </summary>
        public const string BWLNID = "BWLNID";

        /// <summary>
        /// BWDL01.
        /// </summary>
        public const string BWDL01 = "BWDL01";

        /// <summary>
        /// BWSEQ.
        /// </summary>
        public const string BWSEQ = "BWSEQ";
    }

    /// <inheritdoc />
    public override string TableName => "F52G11WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BWDCT", "BWDCT", JdeDataType.String, 4),
        new JdeField("BWDOC", "BWDOC", JdeDataType.Numeric),
        new JdeField("BWKCO", "BWKCO", JdeDataType.String, 10),
        new JdeField("BWDGJ", "BWDGJ", JdeDataType.Numeric),
        new JdeField("BWJELN", "BWJELN", JdeDataType.Numeric),
        new JdeField("BWLT", "BWLT", JdeDataType.String, 4),
        new JdeField("BWEXTL", "BWEXTL", JdeDataType.String, 4),
        new JdeField("BWBUCA", "BWBUCA", JdeDataType.String, 10, true, true),
        new JdeField("BWCO", "BWCO", JdeDataType.String, 10),
        new JdeField("BWMCU", "BWMCU", JdeDataType.String, 24),
        new JdeField("BWOBJ", "BWOBJ", JdeDataType.String, 12),
        new JdeField("BWSUB", "BWSUB", JdeDataType.String, 16),
        new JdeField("BWSBL", "BWSBL", JdeDataType.String, 16),
        new JdeField("BWSBLT", "BWSBLT", JdeDataType.String, 2),
        new JdeField("BWANI", "BWANI", JdeDataType.String, 58),
        new JdeField("BWAID", "BWAID", JdeDataType.String, 16),
        new JdeField("BWPN", "BWPN", JdeDataType.Numeric),
        new JdeField("BWCTRY", "BWCTRY", JdeDataType.Numeric),
        new JdeField("BWFY", "BWFY", JdeDataType.Numeric),
        new JdeField("BWCRCD", "BWCRCD", JdeDataType.String, 6),
        new JdeField("BWU", "BWU", JdeDataType.Numeric),
        new JdeField("BWAA", "BWAA", JdeDataType.Numeric),
        new JdeField("BWAA3", "BWAA3", JdeDataType.Numeric),
        new JdeField("BWITOL", "BWITOL", JdeDataType.Numeric),
        new JdeField("BWBTOL", "BWBTOL", JdeDataType.Numeric),
        new JdeField("BWEXA", "BWEXA", JdeDataType.String, 60),
        new JdeField("BWEXR", "BWEXR", JdeDataType.String, 60),
        new JdeField("BWAN8", "BWAN8", JdeDataType.Numeric),
        new JdeField("BWAHBU", "BWAHBU", JdeDataType.String, 24),
        new JdeField("BWEPGC", "BWEPGC", JdeDataType.String, 6),
        new JdeField("BWJBCD", "BWJBCD", JdeDataType.String, 12),
        new JdeField("BWJBST", "BWJBST", JdeDataType.String, 8),
        new JdeField("BWJPGC", "BWJPGC", JdeDataType.String, 6),
        new JdeField("BWSEGMID", "BWSEGMID", JdeDataType.String, 6),
        new JdeField("BWPOOLID", "BWPOOLID", JdeDataType.String, 8),
        new JdeField("BWDSVJ", "BWDSVJ", JdeDataType.Numeric),
        new JdeField("BWBC", "BWBC", JdeDataType.String, 2),
        new JdeField("BWAID5", "BWAID5", JdeDataType.String, 16),
        new JdeField("BWAID6", "BWAID6", JdeDataType.String, 16),
        new JdeField("BWRAS", "BWRAS", JdeDataType.String, 2),
        new JdeField("BWRAG", "BWRAG", JdeDataType.Numeric),
        new JdeField("BWCTF4", "BWCTF4", JdeDataType.String, 2),
        new JdeField("BWGPF1", "BWGPF1", JdeDataType.String, 2),
        new JdeField("BWFFU3", "BWFFU3", JdeDataType.String, 20),
        new JdeField("BWTXF1", "BWTXF1", JdeDataType.String, 20),
        new JdeField("BWPID", "BWPID", JdeDataType.String, 20),
        new JdeField("BWMKEY", "BWMKEY", JdeDataType.String, 30),
        new JdeField("BWUSER", "BWUSER", JdeDataType.String, 20),
        new JdeField("BWUPMJ", "BWUPMJ", JdeDataType.Numeric),
        new JdeField("BWUPMT", "BWUPMT", JdeDataType.Numeric),
        new JdeField("BWJOBS", "BWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("BWLNID", "BWLNID", JdeDataType.Numeric),
        new JdeField("BWDL01", "BWDL01", JdeDataType.String, 60),
        new JdeField("BWSEQ", "BWSEQ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G11WF_0", "Primary Key on BWBUCA, BWJOBS", new[] { "BWBUCA", "BWJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
