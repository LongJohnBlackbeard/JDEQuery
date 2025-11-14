using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75CDXM - .
/// </summary>
public class F75CDXM : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DXC75CID.
        /// </summary>
        public const string DXC75CID = "DXC75CID";

        /// <summary>
        /// DXC75PID.
        /// </summary>
        public const string DXC75PID = "DXC75PID";

        /// <summary>
        /// DXC75PNAME.
        /// </summary>
        public const string DXC75PNAME = "DXC75PNAME";

        /// <summary>
        /// DXC75CNAME.
        /// </summary>
        public const string DXC75CNAME = "DXC75CNAME";

        /// <summary>
        /// DXC75AVAL.
        /// </summary>
        public const string DXC75AVAL = "DXC75AVAL";

        /// <summary>
        /// DXC75XCST.
        /// </summary>
        public const string DXC75XCST = "DXC75XCST";

        /// <summary>
        /// DXDL01.
        /// </summary>
        public const string DXDL01 = "DXDL01";

        /// <summary>
        /// DXFLAG.
        /// </summary>
        public const string DXFLAG = "DXFLAG";

        /// <summary>
        /// DXUSER.
        /// </summary>
        public const string DXUSER = "DXUSER";

        /// <summary>
        /// DXJOBN.
        /// </summary>
        public const string DXJOBN = "DXJOBN";

        /// <summary>
        /// DXUPMJ.
        /// </summary>
        public const string DXUPMJ = "DXUPMJ";

        /// <summary>
        /// DXUPMT.
        /// </summary>
        public const string DXUPMT = "DXUPMT";

        /// <summary>
        /// DXPID.
        /// </summary>
        public const string DXPID = "DXPID";
    }

    /// <inheritdoc />
    public override string TableName => "F75CDXM";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DXC75CID", "DXC75CID", JdeDataType.Numeric, null, true, true),
        new JdeField("DXC75PID", "DXC75PID", JdeDataType.Numeric, null, true, true),
        new JdeField("DXC75PNAME", "DXC75PNAME", JdeDataType.String, 120),
        new JdeField("DXC75CNAME", "DXC75CNAME", JdeDataType.String, 120),
        new JdeField("DXC75AVAL", "DXC75AVAL", JdeDataType.String, 20),
        new JdeField("DXC75XCST", "DXC75XCST", JdeDataType.String, 60),
        new JdeField("DXDL01", "DXDL01", JdeDataType.String, 60),
        new JdeField("DXFLAG", "DXFLAG", JdeDataType.String, 2),
        new JdeField("DXUSER", "DXUSER", JdeDataType.String, 20),
        new JdeField("DXJOBN", "DXJOBN", JdeDataType.String, 20),
        new JdeField("DXUPMJ", "DXUPMJ", JdeDataType.Numeric),
        new JdeField("DXUPMT", "DXUPMT", JdeDataType.Numeric),
        new JdeField("DXPID", "DXPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75CDXM_0", "Primary Key on DXC75PID, DXC75CID", new[] { "DXC75PID", "DXC75CID" }, isUnique: true, isPrimaryKey: true)
    };
}
