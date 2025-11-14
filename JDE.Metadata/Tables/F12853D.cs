using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12853D - .
/// </summary>
public class F12853D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LWFORI.
        /// </summary>
        public const string LWFORI = "LWFORI";

        /// <summary>
        /// LWDS20.
        /// </summary>
        public const string LWDS20 = "LWDS20";

        /// <summary>
        /// LWDC20.
        /// </summary>
        public const string LWDC20 = "LWDC20";

        /// <summary>
        /// LWCLH1.
        /// </summary>
        public const string LWCLH1 = "LWCLH1";

        /// <summary>
        /// LWCLH2.
        /// </summary>
        public const string LWCLH2 = "LWCLH2";

        /// <summary>
        /// LWFMLA.
        /// </summary>
        public const string LWFMLA = "LWFMLA";

        /// <summary>
        /// LWDCML.
        /// </summary>
        public const string LWDCML = "LWDCML";

        /// <summary>
        /// LWEC.
        /// </summary>
        public const string LWEC = "LWEC";

        /// <summary>
        /// LWDFAM.
        /// </summary>
        public const string LWDFAM = "LWDFAM";

        /// <summary>
        /// LWDITM.
        /// </summary>
        public const string LWDITM = "LWDITM";

        /// <summary>
        /// LWLCT.
        /// </summary>
        public const string LWLCT = "LWLCT";

        /// <summary>
        /// LWEDEN.
        /// </summary>
        public const string LWEDEN = "LWEDEN";

        /// <summary>
        /// LWUSER.
        /// </summary>
        public const string LWUSER = "LWUSER";

        /// <summary>
        /// LWPID.
        /// </summary>
        public const string LWPID = "LWPID";

        /// <summary>
        /// LWUPMJ.
        /// </summary>
        public const string LWUPMJ = "LWUPMJ";

        /// <summary>
        /// LWJOBN.
        /// </summary>
        public const string LWJOBN = "LWJOBN";

        /// <summary>
        /// LWUPMT.
        /// </summary>
        public const string LWUPMT = "LWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F12853D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LWFORI", "LWFORI", JdeDataType.String, 6, true, true),
        new JdeField("LWDS20", "LWDS20", JdeDataType.String, 40),
        new JdeField("LWDC20", "LWDC20", JdeDataType.String, 40),
        new JdeField("LWCLH1", "LWCLH1", JdeDataType.String, 22),
        new JdeField("LWCLH2", "LWCLH2", JdeDataType.String, 22),
        new JdeField("LWFMLA", "LWFMLA", JdeDataType.String, 80),
        new JdeField("LWDCML", "LWDCML", JdeDataType.Numeric),
        new JdeField("LWEC", "LWEC", JdeDataType.String, 2),
        new JdeField("LWDFAM", "LWDFAM", JdeDataType.Numeric),
        new JdeField("LWDITM", "LWDITM", JdeDataType.String, 20),
        new JdeField("LWLCT", "LWLCT", JdeDataType.Numeric),
        new JdeField("LWEDEN", "LWEDEN", JdeDataType.String, 2),
        new JdeField("LWUSER", "LWUSER", JdeDataType.String, 20),
        new JdeField("LWPID", "LWPID", JdeDataType.String, 20),
        new JdeField("LWUPMJ", "LWUPMJ", JdeDataType.Numeric),
        new JdeField("LWJOBN", "LWJOBN", JdeDataType.String, 20),
        new JdeField("LWUPMT", "LWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12853D_0", "Primary Key on LWFORI", new[] { "LWFORI" }, isUnique: true, isPrimaryKey: true)
    };
}
