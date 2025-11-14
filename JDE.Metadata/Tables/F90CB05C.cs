using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB05C - .
/// </summary>
public class F90CB05C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NLOPPID.
        /// </summary>
        public const string NLOPPID = "NLOPPID";

        /// <summary>
        /// NLUKID.
        /// </summary>
        public const string NLUKID = "NLUKID";

        /// <summary>
        /// NLCFGSID.
        /// </summary>
        public const string NLCFGSID = "NLCFGSID";

        /// <summary>
        /// NLDSCRP1.
        /// </summary>
        public const string NLDSCRP1 = "NLDSCRP1";

        /// <summary>
        /// NLSCNAMEF.
        /// </summary>
        public const string NLSCNAMEF = "NLSCNAMEF";

        /// <summary>
        /// NLSCNAMET.
        /// </summary>
        public const string NLSCNAMET = "NLSCNAMET";

        /// <summary>
        /// NLSMDSCRP.
        /// </summary>
        public const string NLSMDSCRP = "NLSMDSCRP";

        /// <summary>
        /// NLCUAN8.
        /// </summary>
        public const string NLCUAN8 = "NLCUAN8";

        /// <summary>
        /// NLCUSAN8.
        /// </summary>
        public const string NLCUSAN8 = "NLCUSAN8";

        /// <summary>
        /// NLSPTDESC.
        /// </summary>
        public const string NLSPTDESC = "NLSPTDESC";

        /// <summary>
        /// NLSDTDESC.
        /// </summary>
        public const string NLSDTDESC = "NLSDTDESC";

        /// <summary>
        /// NLMODESCP.
        /// </summary>
        public const string NLMODESCP = "NLMODESCP";

        /// <summary>
        /// NLUSER.
        /// </summary>
        public const string NLUSER = "NLUSER";

        /// <summary>
        /// NLPID.
        /// </summary>
        public const string NLPID = "NLPID";

        /// <summary>
        /// NLVID.
        /// </summary>
        public const string NLVID = "NLVID";

        /// <summary>
        /// NLMKEY.
        /// </summary>
        public const string NLMKEY = "NLMKEY";

        /// <summary>
        /// NLUDTTM.
        /// </summary>
        public const string NLUDTTM = "NLUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB05C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NLOPPID", "NLOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("NLUKID", "NLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("NLCFGSID", "NLCFGSID", JdeDataType.String, 64),
        new JdeField("NLDSCRP1", "NLDSCRP1", JdeDataType.String, 100),
        new JdeField("NLSCNAMEF", "NLSCNAMEF", JdeDataType.String, 100),
        new JdeField("NLSCNAMET", "NLSCNAMET", JdeDataType.String, 100),
        new JdeField("NLSMDSCRP", "NLSMDSCRP", JdeDataType.String, 100),
        new JdeField("NLCUAN8", "NLCUAN8", JdeDataType.Numeric),
        new JdeField("NLCUSAN8", "NLCUSAN8", JdeDataType.Numeric),
        new JdeField("NLSPTDESC", "NLSPTDESC", JdeDataType.String, 60),
        new JdeField("NLSDTDESC", "NLSDTDESC", JdeDataType.String, 60),
        new JdeField("NLMODESCP", "NLMODESCP", JdeDataType.String, 20),
        new JdeField("NLUSER", "NLUSER", JdeDataType.String, 20),
        new JdeField("NLPID", "NLPID", JdeDataType.String, 20),
        new JdeField("NLVID", "NLVID", JdeDataType.String, 20),
        new JdeField("NLMKEY", "NLMKEY", JdeDataType.String, 30),
        new JdeField("NLUDTTM", "NLUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB05C_0", "Primary Key on NLOPPID, NLUKID", new[] { "NLOPPID", "NLUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
