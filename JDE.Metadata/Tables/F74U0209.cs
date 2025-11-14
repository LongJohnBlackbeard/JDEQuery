using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0209 - .
/// </summary>
public class F74U0209 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PF74UDMIX.
        /// </summary>
        public const string PF74UDMIX = "PF74UDMIX";

        /// <summary>
        /// PF74UOPSTA.
        /// </summary>
        public const string PF74UOPSTA = "PF74UOPSTA";

        /// <summary>
        /// PF74UCNSTA.
        /// </summary>
        public const string PF74UCNSTA = "PF74UCNSTA";

        /// <summary>
        /// PF74USPSTA.
        /// </summary>
        public const string PF74USPSTA = "PF74USPSTA";

        /// <summary>
        /// PF74UGNSTA.
        /// </summary>
        public const string PF74UGNSTA = "PF74UGNSTA";

        /// <summary>
        /// PF74UPDSTA.
        /// </summary>
        public const string PF74UPDSTA = "PF74UPDSTA";

        /// <summary>
        /// PF74UPOSTA.
        /// </summary>
        public const string PF74UPOSTA = "PF74UPOSTA";

        /// <summary>
        /// PFUSER.
        /// </summary>
        public const string PFUSER = "PFUSER";

        /// <summary>
        /// PFPID.
        /// </summary>
        public const string PFPID = "PFPID";

        /// <summary>
        /// PFUPMJ.
        /// </summary>
        public const string PFUPMJ = "PFUPMJ";

        /// <summary>
        /// PFUPMT.
        /// </summary>
        public const string PFUPMT = "PFUPMT";

        /// <summary>
        /// PFJOBN.
        /// </summary>
        public const string PFJOBN = "PFJOBN";

        /// <summary>
        /// PF74UPBD.
        /// </summary>
        public const string PF74UPBD = "PF74UPBD";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0209";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PF74UDMIX", "PF74UDMIX", JdeDataType.String, 2, true, true),
        new JdeField("PF74UOPSTA", "PF74UOPSTA", JdeDataType.String, 2),
        new JdeField("PF74UCNSTA", "PF74UCNSTA", JdeDataType.String, 2),
        new JdeField("PF74USPSTA", "PF74USPSTA", JdeDataType.String, 2),
        new JdeField("PF74UGNSTA", "PF74UGNSTA", JdeDataType.String, 2),
        new JdeField("PF74UPDSTA", "PF74UPDSTA", JdeDataType.String, 2),
        new JdeField("PF74UPOSTA", "PF74UPOSTA", JdeDataType.String, 2),
        new JdeField("PFUSER", "PFUSER", JdeDataType.String, 20),
        new JdeField("PFPID", "PFPID", JdeDataType.String, 20),
        new JdeField("PFUPMJ", "PFUPMJ", JdeDataType.Numeric),
        new JdeField("PFUPMT", "PFUPMT", JdeDataType.Numeric),
        new JdeField("PFJOBN", "PFJOBN", JdeDataType.String, 20),
        new JdeField("PF74UPBD", "PF74UPBD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0209_0", "Primary Key on PF74UDMIX", new[] { "PF74UDMIX" }, isUnique: true, isPrimaryKey: true)
    };
}
