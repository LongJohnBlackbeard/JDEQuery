using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S411 - .
/// </summary>
public class F48S411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BZBCI.
        /// </summary>
        public const string BZBCI = "BZBCI";

        /// <summary>
        /// BZDGL.
        /// </summary>
        public const string BZDGL = "BZDGL";

        /// <summary>
        /// BZSBSQ.
        /// </summary>
        public const string BZSBSQ = "BZSBSQ";

        /// <summary>
        /// BZPRSQ.
        /// </summary>
        public const string BZPRSQ = "BZPRSQ";

        /// <summary>
        /// BZSCSQ.
        /// </summary>
        public const string BZSCSQ = "BZSCSQ";

        /// <summary>
        /// BZSLNK.
        /// </summary>
        public const string BZSLNK = "BZSLNK";

        /// <summary>
        /// BZCLNK.
        /// </summary>
        public const string BZCLNK = "BZCLNK";

        /// <summary>
        /// BZCCOD.
        /// </summary>
        public const string BZCCOD = "BZCCOD";

        /// <summary>
        /// BZDOC.
        /// </summary>
        public const string BZDOC = "BZDOC";

        /// <summary>
        /// BZDCT.
        /// </summary>
        public const string BZDCT = "BZDCT";

        /// <summary>
        /// BZKCO.
        /// </summary>
        public const string BZKCO = "BZKCO";

        /// <summary>
        /// BZDOCZ.
        /// </summary>
        public const string BZDOCZ = "BZDOCZ";

        /// <summary>
        /// BZDCTI.
        /// </summary>
        public const string BZDCTI = "BZDCTI";

        /// <summary>
        /// BZKCOI.
        /// </summary>
        public const string BZKCOI = "BZKCOI";

        /// <summary>
        /// BZSFX.
        /// </summary>
        public const string BZSFX = "BZSFX";

        /// <summary>
        /// BZICU.
        /// </summary>
        public const string BZICU = "BZICU";

        /// <summary>
        /// BZBCTY.
        /// </summary>
        public const string BZBCTY = "BZBCTY";

        /// <summary>
        /// BZPWPG.
        /// </summary>
        public const string BZPWPG = "BZPWPG";

        /// <summary>
        /// BZUSER.
        /// </summary>
        public const string BZUSER = "BZUSER";

        /// <summary>
        /// BZPID.
        /// </summary>
        public const string BZPID = "BZPID";

        /// <summary>
        /// BZUPMJ.
        /// </summary>
        public const string BZUPMJ = "BZUPMJ";

        /// <summary>
        /// BZJOBN.
        /// </summary>
        public const string BZJOBN = "BZJOBN";

        /// <summary>
        /// BZUPMT.
        /// </summary>
        public const string BZUPMT = "BZUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48S411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BZBCI", "BZBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("BZDGL", "BZDGL", JdeDataType.Numeric, null, true, true),
        new JdeField("BZSBSQ", "BZSBSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("BZPRSQ", "BZPRSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("BZSCSQ", "BZSCSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("BZSLNK", "BZSLNK", JdeDataType.Numeric, null, true, true),
        new JdeField("BZCLNK", "BZCLNK", JdeDataType.Numeric, null, true, true),
        new JdeField("BZCCOD", "BZCCOD", JdeDataType.String, 10, true, true),
        new JdeField("BZDOC", "BZDOC", JdeDataType.Numeric),
        new JdeField("BZDCT", "BZDCT", JdeDataType.String, 4),
        new JdeField("BZKCO", "BZKCO", JdeDataType.String, 10),
        new JdeField("BZDOCZ", "BZDOCZ", JdeDataType.Numeric),
        new JdeField("BZDCTI", "BZDCTI", JdeDataType.String, 4),
        new JdeField("BZKCOI", "BZKCOI", JdeDataType.String, 10),
        new JdeField("BZSFX", "BZSFX", JdeDataType.String, 6),
        new JdeField("BZICU", "BZICU", JdeDataType.Numeric),
        new JdeField("BZBCTY", "BZBCTY", JdeDataType.String, 2),
        new JdeField("BZPWPG", "BZPWPG", JdeDataType.Numeric),
        new JdeField("BZUSER", "BZUSER", JdeDataType.String, 20),
        new JdeField("BZPID", "BZPID", JdeDataType.String, 20),
        new JdeField("BZUPMJ", "BZUPMJ", JdeDataType.Numeric),
        new JdeField("BZJOBN", "BZJOBN", JdeDataType.String, 20),
        new JdeField("BZUPMT", "BZUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S411_0", "Primary Key on BZBCI, BZDGL, BZSBSQ, BZPRSQ, BZSCSQ, BZSLNK, BZCLNK, BZCCOD", new[] { "BZBCI", "BZDGL", "BZSBSQ", "BZPRSQ", "BZSCSQ", "BZSLNK", "BZCLNK", "BZCCOD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S411_2", "Index on BZICU, BZBCTY", new[] { "BZICU", "BZBCTY" }),
        new JdeIndex("F48S411_3", "Index on BZDOCZ, BZDCTI, BZKCOI, BZSFX", new[] { "BZDOCZ", "BZDCTI", "BZKCOI", "BZSFX" })
    };
}
