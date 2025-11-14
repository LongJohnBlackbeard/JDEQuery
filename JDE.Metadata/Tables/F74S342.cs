using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S342 - .
/// </summary>
public class F74S342 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SVKCO.
        /// </summary>
        public const string SVKCO = "SVKCO";

        /// <summary>
        /// SVDCT.
        /// </summary>
        public const string SVDCT = "SVDCT";

        /// <summary>
        /// SVDOC.
        /// </summary>
        public const string SVDOC = "SVDOC";

        /// <summary>
        /// SVSFX.
        /// </summary>
        public const string SVSFX = "SVSFX";

        /// <summary>
        /// SVSFXE.
        /// </summary>
        public const string SVSFXE = "SVSFXE";

        /// <summary>
        /// SVGL01.
        /// </summary>
        public const string SVGL01 = "SVGL01";

        /// <summary>
        /// SVS74RENB.
        /// </summary>
        public const string SVS74RENB = "SVS74RENB";

        /// <summary>
        /// SVS740103.
        /// </summary>
        public const string SVS740103 = "SVS740103";

        /// <summary>
        /// SVS740100.
        /// </summary>
        public const string SVS740100 = "SVS740100";

        /// <summary>
        /// SVS740101.
        /// </summary>
        public const string SVS740101 = "SVS740101";

        /// <summary>
        /// SVUSER.
        /// </summary>
        public const string SVUSER = "SVUSER";

        /// <summary>
        /// SVPID.
        /// </summary>
        public const string SVPID = "SVPID";

        /// <summary>
        /// SVUPMJ.
        /// </summary>
        public const string SVUPMJ = "SVUPMJ";

        /// <summary>
        /// SVUPMT.
        /// </summary>
        public const string SVUPMT = "SVUPMT";

        /// <summary>
        /// SVJOBN.
        /// </summary>
        public const string SVJOBN = "SVJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74S342";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SVKCO", "SVKCO", JdeDataType.String, 10, true, true),
        new JdeField("SVDCT", "SVDCT", JdeDataType.String, 4, true, true),
        new JdeField("SVDOC", "SVDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SVSFX", "SVSFX", JdeDataType.String, 6, true, true),
        new JdeField("SVSFXE", "SVSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("SVGL01", "SVGL01", JdeDataType.String, 8, true, true),
        new JdeField("SVS74RENB", "SVS74RENB", JdeDataType.Numeric, null, true, true),
        new JdeField("SVS740103", "SVS740103", JdeDataType.String, 26),
        new JdeField("SVS740100", "SVS740100", JdeDataType.Numeric),
        new JdeField("SVS740101", "SVS740101", JdeDataType.String, 4),
        new JdeField("SVUSER", "SVUSER", JdeDataType.String, 20),
        new JdeField("SVPID", "SVPID", JdeDataType.String, 20),
        new JdeField("SVUPMJ", "SVUPMJ", JdeDataType.Numeric),
        new JdeField("SVUPMT", "SVUPMT", JdeDataType.Numeric),
        new JdeField("SVJOBN", "SVJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S342_0", "Primary Key on SVKCO, SVDCT, SVDOC, SVSFX, SVSFXE, SVGL01, SVS74RENB", new[] { "SVKCO", "SVDCT", "SVDOC", "SVSFX", "SVSFXE", "SVGL01", "SVS74RENB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S342_2", "Index on SVS740103", new[] { "SVS740103" }),
        new JdeIndex("F74S342_3", "Index on SVS740100, SVS740101", new[] { "SVS740100", "SVS740101" })
    };
}
