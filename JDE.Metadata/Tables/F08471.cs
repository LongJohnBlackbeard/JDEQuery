using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08471 - .
/// </summary>
public class F08471 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCPSTNO.
        /// </summary>
        public const string PCPSTNO = "PCPSTNO";

        /// <summary>
        /// PCJCC.
        /// </summary>
        public const string PCJCC = "PCJCC";

        /// <summary>
        /// PCCMPC.
        /// </summary>
        public const string PCCMPC = "PCCMPC";

        /// <summary>
        /// PCDL01.
        /// </summary>
        public const string PCDL01 = "PCDL01";

        /// <summary>
        /// PCCMWT.
        /// </summary>
        public const string PCCMWT = "PCCMWT";

        /// <summary>
        /// PCUKID.
        /// </summary>
        public const string PCUKID = "PCUKID";

        /// <summary>
        /// PCUSDD.
        /// </summary>
        public const string PCUSDD = "PCUSDD";

        /// <summary>
        /// PCCOPTN.
        /// </summary>
        public const string PCCOPTN = "PCCOPTN";

        /// <summary>
        /// PCDL02.
        /// </summary>
        public const string PCDL02 = "PCDL02";

        /// <summary>
        /// PCLVWT.
        /// </summary>
        public const string PCLVWT = "PCLVWT";

        /// <summary>
        /// PCREQL.
        /// </summary>
        public const string PCREQL = "PCREQL";

        /// <summary>
        /// PCDL03.
        /// </summary>
        public const string PCDL03 = "PCDL03";

        /// <summary>
        /// PCSELCMP.
        /// </summary>
        public const string PCSELCMP = "PCSELCMP";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCMKEY.
        /// </summary>
        public const string PCMKEY = "PCMKEY";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08471";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCPSTNO", "PCPSTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("PCJCC", "PCJCC", JdeDataType.String, 20, true, true),
        new JdeField("PCCMPC", "PCCMPC", JdeDataType.String, 20, true, true),
        new JdeField("PCDL01", "PCDL01", JdeDataType.String, 60),
        new JdeField("PCCMWT", "PCCMWT", JdeDataType.Numeric),
        new JdeField("PCUKID", "PCUKID", JdeDataType.Numeric),
        new JdeField("PCUSDD", "PCUSDD", JdeDataType.String, 10),
        new JdeField("PCCOPTN", "PCCOPTN", JdeDataType.String, 6),
        new JdeField("PCDL02", "PCDL02", JdeDataType.String, 60),
        new JdeField("PCLVWT", "PCLVWT", JdeDataType.Numeric),
        new JdeField("PCREQL", "PCREQL", JdeDataType.Numeric),
        new JdeField("PCDL03", "PCDL03", JdeDataType.String, 60),
        new JdeField("PCSELCMP", "PCSELCMP", JdeDataType.String, 2),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCMKEY", "PCMKEY", JdeDataType.String, 30),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08471_0", "Primary Key on PCPSTNO, PCJCC, PCCMPC", new[] { "PCPSTNO", "PCJCC", "PCCMPC" }, isUnique: true, isPrimaryKey: true)
    };
}
