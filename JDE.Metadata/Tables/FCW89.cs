using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW89 - .
/// </summary>
public class FCW89 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMJOBS.
        /// </summary>
        public const string WMJOBS = "WMJOBS";

        /// <summary>
        /// WMUKID.
        /// </summary>
        public const string WMUKID = "WMUKID";

        /// <summary>
        /// WMDOCO.
        /// </summary>
        public const string WMDOCO = "WMDOCO";

        /// <summary>
        /// WMDCTO.
        /// </summary>
        public const string WMDCTO = "WMDCTO";

        /// <summary>
        /// WMSFXO.
        /// </summary>
        public const string WMSFXO = "WMSFXO";

        /// <summary>
        /// WMCPNT.
        /// </summary>
        public const string WMCPNT = "WMCPNT";

        /// <summary>
        /// WMCPIT.
        /// </summary>
        public const string WMCPIT = "WMCPIT";

        /// <summary>
        /// WMCPIL.
        /// </summary>
        public const string WMCPIL = "WMCPIL";

        /// <summary>
        /// WMCMCU.
        /// </summary>
        public const string WMCMCU = "WMCMCU";

        /// <summary>
        /// WMUORG.
        /// </summary>
        public const string WMUORG = "WMUORG";

        /// <summary>
        /// WMTRQT.
        /// </summary>
        public const string WMTRQT = "WMTRQT";

        /// <summary>
        /// WMUSER.
        /// </summary>
        public const string WMUSER = "WMUSER";

        /// <summary>
        /// WMPID.
        /// </summary>
        public const string WMPID = "WMPID";

        /// <summary>
        /// WMJOBN.
        /// </summary>
        public const string WMJOBN = "WMJOBN";

        /// <summary>
        /// WMUPMJ.
        /// </summary>
        public const string WMUPMJ = "WMUPMJ";

        /// <summary>
        /// WMTDAY.
        /// </summary>
        public const string WMTDAY = "WMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW89";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMJOBS", "WMJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WMUKID", "WMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WMDOCO", "WMDOCO", JdeDataType.Numeric),
        new JdeField("WMDCTO", "WMDCTO", JdeDataType.String, 4),
        new JdeField("WMSFXO", "WMSFXO", JdeDataType.String, 6),
        new JdeField("WMCPNT", "WMCPNT", JdeDataType.Numeric),
        new JdeField("WMCPIT", "WMCPIT", JdeDataType.Numeric),
        new JdeField("WMCPIL", "WMCPIL", JdeDataType.String, 50),
        new JdeField("WMCMCU", "WMCMCU", JdeDataType.String, 24),
        new JdeField("WMUORG", "WMUORG", JdeDataType.Numeric),
        new JdeField("WMTRQT", "WMTRQT", JdeDataType.Numeric),
        new JdeField("WMUSER", "WMUSER", JdeDataType.String, 20),
        new JdeField("WMPID", "WMPID", JdeDataType.String, 20),
        new JdeField("WMJOBN", "WMJOBN", JdeDataType.String, 20),
        new JdeField("WMUPMJ", "WMUPMJ", JdeDataType.Numeric),
        new JdeField("WMTDAY", "WMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW89_0", "Primary Key on WMJOBS, WMUKID", new[] { "WMJOBS", "WMUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
