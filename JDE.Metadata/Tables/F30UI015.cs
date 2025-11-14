using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI015 - .
/// </summary>
public class F30UI015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDBOML.
        /// </summary>
        public const string BDBOML = "BDBOML";

        /// <summary>
        /// BDKIT.
        /// </summary>
        public const string BDKIT = "BDKIT";

        /// <summary>
        /// BDMMCU.
        /// </summary>
        public const string BDMMCU = "BDMMCU";

        /// <summary>
        /// BDTBM.
        /// </summary>
        public const string BDTBM = "BDTBM";

        /// <summary>
        /// BDBQTY.
        /// </summary>
        public const string BDBQTY = "BDBQTY";

        /// <summary>
        /// BDUOM.
        /// </summary>
        public const string BDUOM = "BDUOM";

        /// <summary>
        /// BDITM.
        /// </summary>
        public const string BDITM = "BDITM";

        /// <summary>
        /// BDCMCU.
        /// </summary>
        public const string BDCMCU = "BDCMCU";

        /// <summary>
        /// BDQNTY.
        /// </summary>
        public const string BDQNTY = "BDQNTY";

        /// <summary>
        /// BDEXQTY.
        /// </summary>
        public const string BDEXQTY = "BDEXQTY";

        /// <summary>
        /// BDUM.
        /// </summary>
        public const string BDUM = "BDUM";

        /// <summary>
        /// BDEFFF.
        /// </summary>
        public const string BDEFFF = "BDEFFF";

        /// <summary>
        /// BDEFFT.
        /// </summary>
        public const string BDEFFT = "BDEFFT";

        /// <summary>
        /// BDBREV.
        /// </summary>
        public const string BDBREV = "BDBREV";

        /// <summary>
        /// BDCMRV.
        /// </summary>
        public const string BDCMRV = "BDCMRV";

        /// <summary>
        /// BDF$RP.
        /// </summary>
        public const string BDF_RP = "BDF$RP";

        /// <summary>
        /// BDCPNB.
        /// </summary>
        public const string BDCPNB = "BDCPNB";

        /// <summary>
        /// BDOPSQ.
        /// </summary>
        public const string BDOPSQ = "BDOPSQ";

        /// <summary>
        /// BDSCRP.
        /// </summary>
        public const string BDSCRP = "BDSCRP";

        /// <summary>
        /// BDSTPP.
        /// </summary>
        public const string BDSTPP = "BDSTPP";

        /// <summary>
        /// BDLBND.
        /// </summary>
        public const string BDLBND = "BDLBND";

        /// <summary>
        /// BDRBND.
        /// </summary>
        public const string BDRBND = "BDRBND";

        /// <summary>
        /// BDL1PITM.
        /// </summary>
        public const string BDL1PITM = "BDL1PITM";

        /// <summary>
        /// BDL2PITM.
        /// </summary>
        public const string BDL2PITM = "BDL2PITM";

        /// <summary>
        /// BDL3PITM.
        /// </summary>
        public const string BDL3PITM = "BDL3PITM";

        /// <summary>
        /// BDL4PITM.
        /// </summary>
        public const string BDL4PITM = "BDL4PITM";

        /// <summary>
        /// BDL5PITM.
        /// </summary>
        public const string BDL5PITM = "BDL5PITM";

        /// <summary>
        /// BDL6PITM.
        /// </summary>
        public const string BDL6PITM = "BDL6PITM";

        /// <summary>
        /// BDL7PITM.
        /// </summary>
        public const string BDL7PITM = "BDL7PITM";

        /// <summary>
        /// BDL8PITM.
        /// </summary>
        public const string BDL8PITM = "BDL8PITM";

        /// <summary>
        /// BDL9PITM.
        /// </summary>
        public const string BDL9PITM = "BDL9PITM";

        /// <summary>
        /// BDL10PITM.
        /// </summary>
        public const string BDL10PITM = "BDL10PITM";

        /// <summary>
        /// BDUKID.
        /// </summary>
        public const string BDUKID = "BDUKID";

        /// <summary>
        /// BDURCD.
        /// </summary>
        public const string BDURCD = "BDURCD";

        /// <summary>
        /// BDURDT.
        /// </summary>
        public const string BDURDT = "BDURDT";

        /// <summary>
        /// BDURAT.
        /// </summary>
        public const string BDURAT = "BDURAT";

        /// <summary>
        /// BDURAB.
        /// </summary>
        public const string BDURAB = "BDURAB";

        /// <summary>
        /// BDURRF.
        /// </summary>
        public const string BDURRF = "BDURRF";

        /// <summary>
        /// BDUSER.
        /// </summary>
        public const string BDUSER = "BDUSER";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";

        /// <summary>
        /// BDTDAY.
        /// </summary>
        public const string BDTDAY = "BDTDAY";

        /// <summary>
        /// BDMKEY.
        /// </summary>
        public const string BDMKEY = "BDMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDBOML", "BDBOML", JdeDataType.Numeric),
        new JdeField("BDKIT", "BDKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("BDMMCU", "BDMMCU", JdeDataType.String, 24, true, true),
        new JdeField("BDTBM", "BDTBM", JdeDataType.String, 6, true, true),
        new JdeField("BDBQTY", "BDBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("BDUOM", "BDUOM", JdeDataType.String, 4),
        new JdeField("BDITM", "BDITM", JdeDataType.Numeric),
        new JdeField("BDCMCU", "BDCMCU", JdeDataType.String, 24),
        new JdeField("BDQNTY", "BDQNTY", JdeDataType.Numeric),
        new JdeField("BDEXQTY", "BDEXQTY", JdeDataType.Numeric),
        new JdeField("BDUM", "BDUM", JdeDataType.String, 4),
        new JdeField("BDEFFF", "BDEFFF", JdeDataType.Numeric),
        new JdeField("BDEFFT", "BDEFFT", JdeDataType.Numeric),
        new JdeField("BDBREV", "BDBREV", JdeDataType.String, 6, true, true),
        new JdeField("BDCMRV", "BDCMRV", JdeDataType.String, 6),
        new JdeField("BDF$RP", "BDF$RP", JdeDataType.Numeric),
        new JdeField("BDCPNB", "BDCPNB", JdeDataType.Numeric),
        new JdeField("BDOPSQ", "BDOPSQ", JdeDataType.Numeric),
        new JdeField("BDSCRP", "BDSCRP", JdeDataType.Numeric),
        new JdeField("BDSTPP", "BDSTPP", JdeDataType.Numeric),
        new JdeField("BDLBND", "BDLBND", JdeDataType.Numeric, null, true, true),
        new JdeField("BDRBND", "BDRBND", JdeDataType.Numeric),
        new JdeField("BDL1PITM", "BDL1PITM", JdeDataType.Numeric),
        new JdeField("BDL2PITM", "BDL2PITM", JdeDataType.Numeric),
        new JdeField("BDL3PITM", "BDL3PITM", JdeDataType.Numeric),
        new JdeField("BDL4PITM", "BDL4PITM", JdeDataType.Numeric),
        new JdeField("BDL5PITM", "BDL5PITM", JdeDataType.Numeric),
        new JdeField("BDL6PITM", "BDL6PITM", JdeDataType.Numeric),
        new JdeField("BDL7PITM", "BDL7PITM", JdeDataType.Numeric),
        new JdeField("BDL8PITM", "BDL8PITM", JdeDataType.Numeric),
        new JdeField("BDL9PITM", "BDL9PITM", JdeDataType.Numeric),
        new JdeField("BDL10PITM", "BDL10PITM", JdeDataType.Numeric),
        new JdeField("BDUKID", "BDUKID", JdeDataType.Numeric),
        new JdeField("BDURCD", "BDURCD", JdeDataType.String, 4),
        new JdeField("BDURDT", "BDURDT", JdeDataType.Numeric),
        new JdeField("BDURAT", "BDURAT", JdeDataType.Numeric),
        new JdeField("BDURAB", "BDURAB", JdeDataType.Numeric),
        new JdeField("BDURRF", "BDURRF", JdeDataType.String, 30),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDTDAY", "BDTDAY", JdeDataType.Numeric),
        new JdeField("BDMKEY", "BDMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI015_0", "Primary Key on BDKIT, BDMMCU, BDTBM, BDBQTY, BDBREV, BDLBND", new[] { "BDKIT", "BDMMCU", "BDTBM", "BDBQTY", "BDBREV", "BDLBND" }, isUnique: true, isPrimaryKey: true)
    };
}
