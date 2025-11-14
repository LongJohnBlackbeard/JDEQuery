using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085518 - .
/// </summary>
public class F085518 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SOEECD.
        /// </summary>
        public const string SOEECD = "SOEECD";

        /// <summary>
        /// SOVERS.
        /// </summary>
        public const string SOVERS = "SOVERS";

        /// <summary>
        /// SOLNGP.
        /// </summary>
        public const string SOLNGP = "SOLNGP";

        /// <summary>
        /// SOCCPR.
        /// </summary>
        public const string SOCCPR = "SOCCPR";

        /// <summary>
        /// SOCO.
        /// </summary>
        public const string SOCO = "SOCO";

        /// <summary>
        /// SOCSCPF.
        /// </summary>
        public const string SOCSCPF = "SOCSCPF";

        /// <summary>
        /// SOBACKTX.
        /// </summary>
        public const string SOBACKTX = "SOBACKTX";

        /// <summary>
        /// SONEXTTX.
        /// </summary>
        public const string SONEXTTX = "SONEXTTX";

        /// <summary>
        /// SOPRNTTX.
        /// </summary>
        public const string SOPRNTTX = "SOPRNTTX";

        /// <summary>
        /// SOMAILTX.
        /// </summary>
        public const string SOMAILTX = "SOMAILTX";

        /// <summary>
        /// SOEMALTX.
        /// </summary>
        public const string SOEMALTX = "SOEMALTX";

        /// <summary>
        /// SOSBCHTX.
        /// </summary>
        public const string SOSBCHTX = "SOSBCHTX";

        /// <summary>
        /// SOSEMHRTX.
        /// </summary>
        public const string SOSEMHRTX = "SOSEMHRTX";

        /// <summary>
        /// SOHDBACK.
        /// </summary>
        public const string SOHDBACK = "SOHDBACK";

        /// <summary>
        /// SOHDEMAIL.
        /// </summary>
        public const string SOHDEMAIL = "SOHDEMAIL";

        /// <summary>
        /// SOHDMAIL.
        /// </summary>
        public const string SOHDMAIL = "SOHDMAIL";

        /// <summary>
        /// SOHDPRT.
        /// </summary>
        public const string SOHDPRT = "SOHDPRT";

        /// <summary>
        /// SOGPTX.
        /// </summary>
        public const string SOGPTX = "SOGPTX";

        /// <summary>
        /// SOHDNEXT.
        /// </summary>
        public const string SOHDNEXT = "SOHDNEXT";

        /// <summary>
        /// SOUSER.
        /// </summary>
        public const string SOUSER = "SOUSER";

        /// <summary>
        /// SOPID.
        /// </summary>
        public const string SOPID = "SOPID";

        /// <summary>
        /// SOJOBN.
        /// </summary>
        public const string SOJOBN = "SOJOBN";

        /// <summary>
        /// SOUPMT.
        /// </summary>
        public const string SOUPMT = "SOUPMT";

        /// <summary>
        /// SOUPMJ.
        /// </summary>
        public const string SOUPMJ = "SOUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F085518";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SOEECD", "SOEECD", JdeDataType.String, 6, true, true),
        new JdeField("SOVERS", "SOVERS", JdeDataType.String, 20, true, true),
        new JdeField("SOLNGP", "SOLNGP", JdeDataType.String, 4, true, true),
        new JdeField("SOCCPR", "SOCCPR", JdeDataType.String, 6, true, true),
        new JdeField("SOCO", "SOCO", JdeDataType.String, 10, true, true),
        new JdeField("SOCSCPF", "SOCSCPF", JdeDataType.String, 2, true, true),
        new JdeField("SOBACKTX", "SOBACKTX", JdeDataType.String, 30),
        new JdeField("SONEXTTX", "SONEXTTX", JdeDataType.String, 30),
        new JdeField("SOPRNTTX", "SOPRNTTX", JdeDataType.String, 30),
        new JdeField("SOMAILTX", "SOMAILTX", JdeDataType.String, 30),
        new JdeField("SOEMALTX", "SOEMALTX", JdeDataType.String, 30),
        new JdeField("SOSBCHTX", "SOSBCHTX", JdeDataType.String, 60),
        new JdeField("SOSEMHRTX", "SOSEMHRTX", JdeDataType.String, 60),
        new JdeField("SOHDBACK", "SOHDBACK", JdeDataType.String, 2),
        new JdeField("SOHDEMAIL", "SOHDEMAIL", JdeDataType.String, 2),
        new JdeField("SOHDMAIL", "SOHDMAIL", JdeDataType.String, 2),
        new JdeField("SOHDPRT", "SOHDPRT", JdeDataType.String, 2),
        new JdeField("SOGPTX", "SOGPTX", JdeDataType.String, 3000),
        new JdeField("SOHDNEXT", "SOHDNEXT", JdeDataType.String, 2),
        new JdeField("SOUSER", "SOUSER", JdeDataType.String, 20),
        new JdeField("SOPID", "SOPID", JdeDataType.String, 20),
        new JdeField("SOJOBN", "SOJOBN", JdeDataType.String, 20),
        new JdeField("SOUPMT", "SOUPMT", JdeDataType.Numeric),
        new JdeField("SOUPMJ", "SOUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085518_0", "Primary Key on SOEECD, SOVERS, SOLNGP, SOCCPR, SOCO, SOCSCPF", new[] { "SOEECD", "SOVERS", "SOLNGP", "SOCCPR", "SOCO", "SOCSCPF" }, isUnique: true, isPrimaryKey: true)
    };
}
