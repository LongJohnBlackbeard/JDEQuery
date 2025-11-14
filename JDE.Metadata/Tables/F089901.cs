using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F089901 - .
/// </summary>
public class F089901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCO.
        /// </summary>
        public const string CCCO = "CCCO";

        /// <summary>
        /// CCHMCU.
        /// </summary>
        public const string CCHMCU = "CCHMCU";

        /// <summary>
        /// CCEFTB.
        /// </summary>
        public const string CCEFTB = "CCEFTB";

        /// <summary>
        /// CCEFTE.
        /// </summary>
        public const string CCEFTE = "CCEFTE";

        /// <summary>
        /// CCTARR.
        /// </summary>
        public const string CCTARR = "CCTARR";

        /// <summary>
        /// CCAFSA.
        /// </summary>
        public const string CCAFSA = "CCAFSA";

        /// <summary>
        /// CCAFS.
        /// </summary>
        public const string CCAFS = "CCAFS";

        /// <summary>
        /// CCENDDTE.
        /// </summary>
        public const string CCENDDTE = "CCENDDTE";

        /// <summary>
        /// CCSCCP.
        /// </summary>
        public const string CCSCCP = "CCSCCP";

        /// <summary>
        /// CCSCF.
        /// </summary>
        public const string CCSCF = "CCSCF";

        /// <summary>
        /// CCCOBRA.
        /// </summary>
        public const string CCCOBRA = "CCCOBRA";

        /// <summary>
        /// CCHIPAA.
        /// </summary>
        public const string CCHIPAA = "CCHIPAA";

        /// <summary>
        /// CCCOBRADL.
        /// </summary>
        public const string CCCOBRADL = "CCCOBRADL";

        /// <summary>
        /// CCCGL.
        /// </summary>
        public const string CCCGL = "CCCGL";

        /// <summary>
        /// CCCOBRATN.
        /// </summary>
        public const string CCCOBRATN = "CCCOBRATN";

        /// <summary>
        /// CCCOBRAURL.
        /// </summary>
        public const string CCCOBRAURL = "CCCOBRAURL";

        /// <summary>
        /// CCCADD.
        /// </summary>
        public const string CCCADD = "CCCADD";

        /// <summary>
        /// CCPCOBRAL.
        /// </summary>
        public const string CCPCOBRAL = "CCPCOBRAL";

        /// <summary>
        /// CCAPCL.
        /// </summary>
        public const string CCAPCL = "CCAPCL";

        /// <summary>
        /// CCCUFLG.
        /// </summary>
        public const string CCCUFLG = "CCCUFLG";

        /// <summary>
        /// CCDMCN.
        /// </summary>
        public const string CCDMCN = "CCDMCN";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F089901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCO", "CCCO", JdeDataType.String, 10, true, true),
        new JdeField("CCHMCU", "CCHMCU", JdeDataType.String, 24, true, true),
        new JdeField("CCEFTB", "CCEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("CCEFTE", "CCEFTE", JdeDataType.Numeric),
        new JdeField("CCTARR", "CCTARR", JdeDataType.String, 20, true, true),
        new JdeField("CCAFSA", "CCAFSA", JdeDataType.Numeric),
        new JdeField("CCAFS", "CCAFS", JdeDataType.String, 2),
        new JdeField("CCENDDTE", "CCENDDTE", JdeDataType.Numeric),
        new JdeField("CCSCCP", "CCSCCP", JdeDataType.Numeric),
        new JdeField("CCSCF", "CCSCF", JdeDataType.String, 2),
        new JdeField("CCCOBRA", "CCCOBRA", JdeDataType.String, 20),
        new JdeField("CCHIPAA", "CCHIPAA", JdeDataType.String, 20),
        new JdeField("CCCOBRADL", "CCCOBRADL", JdeDataType.String, 20),
        new JdeField("CCCGL", "CCCGL", JdeDataType.String, 20),
        new JdeField("CCCOBRATN", "CCCOBRATN", JdeDataType.String, 40),
        new JdeField("CCCOBRAURL", "CCCOBRAURL", JdeDataType.String, 400),
        new JdeField("CCCADD", "CCCADD", JdeDataType.String, 2),
        new JdeField("CCPCOBRAL", "CCPCOBRAL", JdeDataType.String, 2),
        new JdeField("CCAPCL", "CCAPCL", JdeDataType.String, 2),
        new JdeField("CCCUFLG", "CCCUFLG", JdeDataType.String, 2),
        new JdeField("CCDMCN", "CCDMCN", JdeDataType.Numeric),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F089901_0", "Primary Key on CCCO, CCHMCU, CCTARR, CCEFTB", new[] { "CCCO", "CCHMCU", "CCTARR", "CCEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F089901_2", "Index on CCCO, CCHMCU, CCEFTB, CCEFTE", new[] { "CCCO", "CCHMCU", "CCEFTB", "CCEFTE" }),
        new JdeIndex("F089901_3", "Index on CCCO, CCEFTB, CCEFTE", new[] { "CCCO", "CCEFTB", "CCEFTE" }),
        new JdeIndex("F089901_4", "Index on CCCO, CCTARR, CCEFTB, CCEFTE", new[] { "CCCO", "CCTARR", "CCEFTB", "CCEFTE" }),
        new JdeIndex("F089901_5", "Index on CCCO, CCHMCU, SYS_NC00027$, SYS_NC00028$, CCTARR", new[] { "CCCO", "CCHMCU", "SYS_NC00027$", "SYS_NC00028$", "CCTARR" })
    };
}
