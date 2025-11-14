using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B29 - .
/// </summary>
public class F03B29 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IPAN8I.
        /// </summary>
        public const string IPAN8I = "IPAN8I";

        /// <summary>
        /// IPIPT.
        /// </summary>
        public const string IPIPT = "IPIPT";

        /// <summary>
        /// IPINSP.
        /// </summary>
        public const string IPINSP = "IPINSP";

        /// <summary>
        /// IPDEF.
        /// </summary>
        public const string IPDEF = "IPDEF";

        /// <summary>
        /// IPEND.
        /// </summary>
        public const string IPEND = "IPEND";

        /// <summary>
        /// IPINA.
        /// </summary>
        public const string IPINA = "IPINA";

        /// <summary>
        /// IPCRCD.
        /// </summary>
        public const string IPCRCD = "IPCRCD";

        /// <summary>
        /// IPIPA.
        /// </summary>
        public const string IPIPA = "IPIPA";

        /// <summary>
        /// IPCRCF.
        /// </summary>
        public const string IPCRCF = "IPCRCF";

        /// <summary>
        /// IPCOVP.
        /// </summary>
        public const string IPCOVP = "IPCOVP";

        /// <summary>
        /// IPU.
        /// </summary>
        public const string IPU = "IPU";

        /// <summary>
        /// IPUNCS.
        /// </summary>
        public const string IPUNCS = "IPUNCS";

        /// <summary>
        /// IPCO.
        /// </summary>
        public const string IPCO = "IPCO";

        /// <summary>
        /// IPAN8.
        /// </summary>
        public const string IPAN8 = "IPAN8";

        /// <summary>
        /// IPUSER.
        /// </summary>
        public const string IPUSER = "IPUSER";

        /// <summary>
        /// IPPID.
        /// </summary>
        public const string IPPID = "IPPID";

        /// <summary>
        /// IPJOBN.
        /// </summary>
        public const string IPJOBN = "IPJOBN";

        /// <summary>
        /// IPUPMJ.
        /// </summary>
        public const string IPUPMJ = "IPUPMJ";

        /// <summary>
        /// IPUPMT.
        /// </summary>
        public const string IPUPMT = "IPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F03B29";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IPAN8I", "IPAN8I", JdeDataType.Numeric, null, true, true),
        new JdeField("IPIPT", "IPIPT", JdeDataType.String, 2),
        new JdeField("IPINSP", "IPINSP", JdeDataType.String, 50, true, true),
        new JdeField("IPDEF", "IPDEF", JdeDataType.Numeric),
        new JdeField("IPEND", "IPEND", JdeDataType.Numeric),
        new JdeField("IPINA", "IPINA", JdeDataType.Numeric),
        new JdeField("IPCRCD", "IPCRCD", JdeDataType.String, 6),
        new JdeField("IPIPA", "IPIPA", JdeDataType.Numeric),
        new JdeField("IPCRCF", "IPCRCF", JdeDataType.String, 6),
        new JdeField("IPCOVP", "IPCOVP", JdeDataType.Numeric),
        new JdeField("IPU", "IPU", JdeDataType.Numeric),
        new JdeField("IPUNCS", "IPUNCS", JdeDataType.Numeric),
        new JdeField("IPCO", "IPCO", JdeDataType.String, 10),
        new JdeField("IPAN8", "IPAN8", JdeDataType.Numeric),
        new JdeField("IPUSER", "IPUSER", JdeDataType.String, 20),
        new JdeField("IPPID", "IPPID", JdeDataType.String, 20),
        new JdeField("IPJOBN", "IPJOBN", JdeDataType.String, 20),
        new JdeField("IPUPMJ", "IPUPMJ", JdeDataType.Numeric),
        new JdeField("IPUPMT", "IPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B29_0", "Primary Key on IPINSP, IPAN8I", new[] { "IPINSP", "IPAN8I" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B29_2", "Index on IPAN8I", new[] { "IPAN8I" }),
        new JdeIndex("F03B29_3", "Index on IPAN8, IPCO", new[] { "IPAN8", "IPCO" })
    };
}
