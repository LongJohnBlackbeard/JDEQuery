using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI123 - .
/// </summary>
public class F09UI123 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VWJOBS.
        /// </summary>
        public const string VWJOBS = "VWJOBS";

        /// <summary>
        /// VWUKID.
        /// </summary>
        public const string VWUKID = "VWUKID";

        /// <summary>
        /// VWRTAL.
        /// </summary>
        public const string VWRTAL = "VWRTAL";

        /// <summary>
        /// VWMCU.
        /// </summary>
        public const string VWMCU = "VWMCU";

        /// <summary>
        /// VWOBJ.
        /// </summary>
        public const string VWOBJ = "VWOBJ";

        /// <summary>
        /// VWSUB.
        /// </summary>
        public const string VWSUB = "VWSUB";

        /// <summary>
        /// VWSBL.
        /// </summary>
        public const string VWSBL = "VWSBL";

        /// <summary>
        /// VWSBLT.
        /// </summary>
        public const string VWSBLT = "VWSBLT";

        /// <summary>
        /// VWBAVL.
        /// </summary>
        public const string VWBAVL = "VWBAVL";

        /// <summary>
        /// VWDL01.
        /// </summary>
        public const string VWDL01 = "VWDL01";

        /// <summary>
        /// VWDOC.
        /// </summary>
        public const string VWDOC = "VWDOC";

        /// <summary>
        /// VWDCT.
        /// </summary>
        public const string VWDCT = "VWDCT";

        /// <summary>
        /// VWCO.
        /// </summary>
        public const string VWCO = "VWCO";

        /// <summary>
        /// VWPOSG.
        /// </summary>
        public const string VWPOSG = "VWPOSG";

        /// <summary>
        /// VWSEN.
        /// </summary>
        public const string VWSEN = "VWSEN";

        /// <summary>
        /// VWCTRY.
        /// </summary>
        public const string VWCTRY = "VWCTRY";

        /// <summary>
        /// VWFY.
        /// </summary>
        public const string VWFY = "VWFY";

        /// <summary>
        /// VWPN.
        /// </summary>
        public const string VWPN = "VWPN";

        /// <summary>
        /// VWLT.
        /// </summary>
        public const string VWLT = "VWLT";

        /// <summary>
        /// VWAA.
        /// </summary>
        public const string VWAA = "VWAA";

        /// <summary>
        /// VWAN01.
        /// </summary>
        public const string VWAN01 = "VWAN01";

        /// <summary>
        /// VWCRCX.
        /// </summary>
        public const string VWCRCX = "VWCRCX";

        /// <summary>
        /// VWU.
        /// </summary>
        public const string VWU = "VWU";

        /// <summary>
        /// VWMN29D9.
        /// </summary>
        public const string VWMN29D9 = "VWMN29D9";

        /// <summary>
        /// VWEPGC.
        /// </summary>
        public const string VWEPGC = "VWEPGC";

        /// <summary>
        /// VWJPGC.
        /// </summary>
        public const string VWJPGC = "VWJPGC";

        /// <summary>
        /// VWEV01.
        /// </summary>
        public const string VWEV01 = "VWEV01";

        /// <summary>
        /// VWUSER.
        /// </summary>
        public const string VWUSER = "VWUSER";

        /// <summary>
        /// VWPID.
        /// </summary>
        public const string VWPID = "VWPID";

        /// <summary>
        /// VWJOBN.
        /// </summary>
        public const string VWJOBN = "VWJOBN";

        /// <summary>
        /// VWUPMJ.
        /// </summary>
        public const string VWUPMJ = "VWUPMJ";

        /// <summary>
        /// VWUPMT.
        /// </summary>
        public const string VWUPMT = "VWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09UI123";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VWJOBS", "VWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("VWUKID", "VWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("VWRTAL", "VWRTAL", JdeDataType.String, 2, true, true),
        new JdeField("VWMCU", "VWMCU", JdeDataType.String, 24, true, true),
        new JdeField("VWOBJ", "VWOBJ", JdeDataType.String, 12, true, true),
        new JdeField("VWSUB", "VWSUB", JdeDataType.String, 16, true, true),
        new JdeField("VWSBL", "VWSBL", JdeDataType.String, 16, true, true),
        new JdeField("VWSBLT", "VWSBLT", JdeDataType.String, 2, true, true),
        new JdeField("VWBAVL", "VWBAVL", JdeDataType.String, 24, true, true),
        new JdeField("VWDL01", "VWDL01", JdeDataType.String, 60),
        new JdeField("VWDOC", "VWDOC", JdeDataType.Numeric),
        new JdeField("VWDCT", "VWDCT", JdeDataType.String, 4),
        new JdeField("VWCO", "VWCO", JdeDataType.String, 10),
        new JdeField("VWPOSG", "VWPOSG", JdeDataType.Numeric),
        new JdeField("VWSEN", "VWSEN", JdeDataType.Numeric),
        new JdeField("VWCTRY", "VWCTRY", JdeDataType.Numeric),
        new JdeField("VWFY", "VWFY", JdeDataType.Numeric),
        new JdeField("VWPN", "VWPN", JdeDataType.Numeric),
        new JdeField("VWLT", "VWLT", JdeDataType.String, 4),
        new JdeField("VWAA", "VWAA", JdeDataType.Numeric),
        new JdeField("VWAN01", "VWAN01", JdeDataType.Numeric),
        new JdeField("VWCRCX", "VWCRCX", JdeDataType.String, 6),
        new JdeField("VWU", "VWU", JdeDataType.Numeric),
        new JdeField("VWMN29D9", "VWMN29D9", JdeDataType.Numeric),
        new JdeField("VWEPGC", "VWEPGC", JdeDataType.String, 6),
        new JdeField("VWJPGC", "VWJPGC", JdeDataType.String, 6),
        new JdeField("VWEV01", "VWEV01", JdeDataType.String, 2),
        new JdeField("VWUSER", "VWUSER", JdeDataType.String, 20),
        new JdeField("VWPID", "VWPID", JdeDataType.String, 20),
        new JdeField("VWJOBN", "VWJOBN", JdeDataType.String, 20),
        new JdeField("VWUPMJ", "VWUPMJ", JdeDataType.Numeric),
        new JdeField("VWUPMT", "VWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI123_0", "Primary Key on VWJOBS, VWUKID, VWRTAL, VWMCU, VWOBJ, VWSUB, VWSBL, VWSBLT, VWBAVL", new[] { "VWJOBS", "VWUKID", "VWRTAL", "VWMCU", "VWOBJ", "VWSUB", "VWSBL", "VWSBLT", "VWBAVL" }, isUnique: true, isPrimaryKey: true)
    };
}
