using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75Z0009 - .
/// </summary>
public class F75Z0009 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TXAN8.
        /// </summary>
        public const string TXAN8 = "TXAN8";

        /// <summary>
        /// TXCKCN.
        /// </summary>
        public const string TXCKCN = "TXCKCN";

        /// <summary>
        /// TXTARA.
        /// </summary>
        public const string TXTARA = "TXTARA";

        /// <summary>
        /// TXPTAX.
        /// </summary>
        public const string TXPTAX = "TXPTAX";

        /// <summary>
        /// TXINPUTNO.
        /// </summary>
        public const string TXINPUTNO = "TXINPUTNO";

        /// <summary>
        /// TXPAYD.
        /// </summary>
        public const string TXPAYD = "TXPAYD";

        /// <summary>
        /// TXDGJ.
        /// </summary>
        public const string TXDGJ = "TXDGJ";

        /// <summary>
        /// TXGTXBLE.
        /// </summary>
        public const string TXGTXBLE = "TXGTXBLE";

        /// <summary>
        /// TXEARNNL.
        /// </summary>
        public const string TXEARNNL = "TXEARNNL";

        /// <summary>
        /// TXERNPTAX.
        /// </summary>
        public const string TXERNPTAX = "TXERNPTAX";

        /// <summary>
        /// TXLUMPSF.
        /// </summary>
        public const string TXLUMPSF = "TXLUMPSF";

        /// <summary>
        /// TXEPLMF.
        /// </summary>
        public const string TXEPLMF = "TXEPLMF";

        /// <summary>
        /// TXRDRTAF.
        /// </summary>
        public const string TXRDRTAF = "TXRDRTAF";

        /// <summary>
        /// TXPID.
        /// </summary>
        public const string TXPID = "TXPID";

        /// <summary>
        /// TXUSER.
        /// </summary>
        public const string TXUSER = "TXUSER";

        /// <summary>
        /// TXMKEY.
        /// </summary>
        public const string TXMKEY = "TXMKEY";

        /// <summary>
        /// TXUPMJ.
        /// </summary>
        public const string TXUPMJ = "TXUPMJ";

        /// <summary>
        /// TXUPMT.
        /// </summary>
        public const string TXUPMT = "TXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75Z0009";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TXAN8", "TXAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TXCKCN", "TXCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("TXTARA", "TXTARA", JdeDataType.String, 20, true, true),
        new JdeField("TXPTAX", "TXPTAX", JdeDataType.String, 4, true, true),
        new JdeField("TXINPUTNO", "TXINPUTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("TXPAYD", "TXPAYD", JdeDataType.String, 20),
        new JdeField("TXDGJ", "TXDGJ", JdeDataType.Numeric),
        new JdeField("TXGTXBLE", "TXGTXBLE", JdeDataType.Numeric),
        new JdeField("TXEARNNL", "TXEARNNL", JdeDataType.Numeric),
        new JdeField("TXERNPTAX", "TXERNPTAX", JdeDataType.Numeric),
        new JdeField("TXLUMPSF", "TXLUMPSF", JdeDataType.String, 2),
        new JdeField("TXEPLMF", "TXEPLMF", JdeDataType.String, 2),
        new JdeField("TXRDRTAF", "TXRDRTAF", JdeDataType.String, 2),
        new JdeField("TXPID", "TXPID", JdeDataType.String, 20),
        new JdeField("TXUSER", "TXUSER", JdeDataType.String, 20),
        new JdeField("TXMKEY", "TXMKEY", JdeDataType.String, 30),
        new JdeField("TXUPMJ", "TXUPMJ", JdeDataType.Numeric),
        new JdeField("TXUPMT", "TXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75Z0009_0", "Primary Key on TXAN8, TXCKCN, TXTARA, TXPTAX, TXINPUTNO", new[] { "TXAN8", "TXCKCN", "TXTARA", "TXPTAX", "TXINPUTNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75Z0009_2", "Index on TXAN8, SYS_NC00019$, TXTARA, TXPTAX, TXINPUTNO", new[] { "TXAN8", "SYS_NC00019$", "TXTARA", "TXPTAX", "TXINPUTNO" })
    };
}
