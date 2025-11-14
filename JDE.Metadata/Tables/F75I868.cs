using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I868 - .
/// </summary>
public class F75I868 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FGDOCO.
        /// </summary>
        public const string FGDOCO = "FGDOCO";

        /// <summary>
        /// FGDCTO.
        /// </summary>
        public const string FGDCTO = "FGDCTO";

        /// <summary>
        /// FGKCOO.
        /// </summary>
        public const string FGKCOO = "FGKCOO";

        /// <summary>
        /// FGLNID.
        /// </summary>
        public const string FGLNID = "FGLNID";

        /// <summary>
        /// FGI75CGSTR.
        /// </summary>
        public const string FGI75CGSTR = "FGI75CGSTR";

        /// <summary>
        /// FGI75SGSTR.
        /// </summary>
        public const string FGI75SGSTR = "FGI75SGSTR";

        /// <summary>
        /// FGI75IGSTR.
        /// </summary>
        public const string FGI75IGSTR = "FGI75IGSTR";

        /// <summary>
        /// FGI75CESSR.
        /// </summary>
        public const string FGI75CESSR = "FGI75CESSR";

        /// <summary>
        /// FGI75CGSTA.
        /// </summary>
        public const string FGI75CGSTA = "FGI75CGSTA";

        /// <summary>
        /// FGI75SGSTA.
        /// </summary>
        public const string FGI75SGSTA = "FGI75SGSTA";

        /// <summary>
        /// FGI75IGSTA.
        /// </summary>
        public const string FGI75IGSTA = "FGI75IGSTA";

        /// <summary>
        /// FGI75CESSA.
        /// </summary>
        public const string FGI75CESSA = "FGI75CESSA";

        /// <summary>
        /// FGI75SERAC.
        /// </summary>
        public const string FGI75SERAC = "FGI75SERAC";

        /// <summary>
        /// FGI75FRC.
        /// </summary>
        public const string FGI75FRC = "FGI75FRC";

        /// <summary>
        /// FGUSER.
        /// </summary>
        public const string FGUSER = "FGUSER";

        /// <summary>
        /// FGPID.
        /// </summary>
        public const string FGPID = "FGPID";

        /// <summary>
        /// FGJOBN.
        /// </summary>
        public const string FGJOBN = "FGJOBN";

        /// <summary>
        /// FGUPMJ.
        /// </summary>
        public const string FGUPMJ = "FGUPMJ";

        /// <summary>
        /// FGUPMT.
        /// </summary>
        public const string FGUPMT = "FGUPMT";

        /// <summary>
        /// FGYFUTDT.
        /// </summary>
        public const string FGYFUTDT = "FGYFUTDT";

        /// <summary>
        /// FGFFU4.
        /// </summary>
        public const string FGFFU4 = "FGFFU4";

        /// <summary>
        /// FGFUT3.
        /// </summary>
        public const string FGFUT3 = "FGFUT3";

        /// <summary>
        /// FGX2.
        /// </summary>
        public const string FGX2 = "FGX2";

        /// <summary>
        /// FGFUTCH1.
        /// </summary>
        public const string FGFUTCH1 = "FGFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I868";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FGDOCO", "FGDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("FGDCTO", "FGDCTO", JdeDataType.String, 4, true, true),
        new JdeField("FGKCOO", "FGKCOO", JdeDataType.String, 10, true, true),
        new JdeField("FGLNID", "FGLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("FGI75CGSTR", "FGI75CGSTR", JdeDataType.Numeric),
        new JdeField("FGI75SGSTR", "FGI75SGSTR", JdeDataType.Numeric),
        new JdeField("FGI75IGSTR", "FGI75IGSTR", JdeDataType.Numeric),
        new JdeField("FGI75CESSR", "FGI75CESSR", JdeDataType.Numeric),
        new JdeField("FGI75CGSTA", "FGI75CGSTA", JdeDataType.Numeric),
        new JdeField("FGI75SGSTA", "FGI75SGSTA", JdeDataType.Numeric),
        new JdeField("FGI75IGSTA", "FGI75IGSTA", JdeDataType.Numeric),
        new JdeField("FGI75CESSA", "FGI75CESSA", JdeDataType.Numeric),
        new JdeField("FGI75SERAC", "FGI75SERAC", JdeDataType.String, 40),
        new JdeField("FGI75FRC", "FGI75FRC", JdeDataType.String, 2),
        new JdeField("FGUSER", "FGUSER", JdeDataType.String, 20),
        new JdeField("FGPID", "FGPID", JdeDataType.String, 20),
        new JdeField("FGJOBN", "FGJOBN", JdeDataType.String, 20),
        new JdeField("FGUPMJ", "FGUPMJ", JdeDataType.Numeric),
        new JdeField("FGUPMT", "FGUPMT", JdeDataType.Numeric),
        new JdeField("FGYFUTDT", "FGYFUTDT", JdeDataType.Numeric),
        new JdeField("FGFFU4", "FGFFU4", JdeDataType.Numeric),
        new JdeField("FGFUT3", "FGFUT3", JdeDataType.String, 60),
        new JdeField("FGX2", "FGX2", JdeDataType.String, 2),
        new JdeField("FGFUTCH1", "FGFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I868_0", "Primary Key on FGDOCO, FGDCTO, FGKCOO, FGLNID", new[] { "FGDOCO", "FGDCTO", "FGKCOO", "FGLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
