using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M572 - .
/// </summary>
public class F76M572 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSHDC.
        /// </summary>
        public const string WSHDC = "WSHDC";

        /// <summary>
        /// WSCKC.
        /// </summary>
        public const string WSCKC = "WSCKC";

        /// <summary>
        /// WSM76WHTP.
        /// </summary>
        public const string WSM76WHTP = "WSM76WHTP";

        /// <summary>
        /// WSM76WCON.
        /// </summary>
        public const string WSM76WCON = "WSM76WCON";

        /// <summary>
        /// WSM76LCON.
        /// </summary>
        public const string WSM76LCON = "WSM76LCON";

        /// <summary>
        /// WSDOCM.
        /// </summary>
        public const string WSDOCM = "WSDOCM";

        /// <summary>
        /// WSAA.
        /// </summary>
        public const string WSAA = "WSAA";

        /// <summary>
        /// WSACR.
        /// </summary>
        public const string WSACR = "WSACR";

        /// <summary>
        /// WSTAXE.
        /// </summary>
        public const string WSTAXE = "WSTAXE";

        /// <summary>
        /// WSM76WPER.
        /// </summary>
        public const string WSM76WPER = "WSM76WPER";

        /// <summary>
        /// WSM76ASWH.
        /// </summary>
        public const string WSM76ASWH = "WSM76ASWH";

        /// <summary>
        /// WSKCO.
        /// </summary>
        public const string WSKCO = "WSKCO";

        /// <summary>
        /// WSDOC.
        /// </summary>
        public const string WSDOC = "WSDOC";

        /// <summary>
        /// WSDCT.
        /// </summary>
        public const string WSDCT = "WSDCT";

        /// <summary>
        /// WSM76GORT.
        /// </summary>
        public const string WSM76GORT = "WSM76GORT";

        /// <summary>
        /// WSM76FDAT.
        /// </summary>
        public const string WSM76FDAT = "WSM76FDAT";

        /// <summary>
        /// WSM76FFLG.
        /// </summary>
        public const string WSM76FFLG = "WSM76FFLG";

        /// <summary>
        /// WSM76FNUM.
        /// </summary>
        public const string WSM76FNUM = "WSM76FNUM";

        /// <summary>
        /// WSM76FSTR.
        /// </summary>
        public const string WSM76FSTR = "WSM76FSTR";

        /// <summary>
        /// WSUSER.
        /// </summary>
        public const string WSUSER = "WSUSER";

        /// <summary>
        /// WSPID.
        /// </summary>
        public const string WSPID = "WSPID";

        /// <summary>
        /// WSJOBN.
        /// </summary>
        public const string WSJOBN = "WSJOBN";

        /// <summary>
        /// WSUPMJ.
        /// </summary>
        public const string WSUPMJ = "WSUPMJ";

        /// <summary>
        /// WSUPMT.
        /// </summary>
        public const string WSUPMT = "WSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M572";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSHDC", "WSHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("WSCKC", "WSCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("WSM76WHTP", "WSM76WHTP", JdeDataType.String, 2, true, true),
        new JdeField("WSM76WCON", "WSM76WCON", JdeDataType.String, 6, true, true),
        new JdeField("WSM76LCON", "WSM76LCON", JdeDataType.String, 6),
        new JdeField("WSDOCM", "WSDOCM", JdeDataType.Numeric),
        new JdeField("WSAA", "WSAA", JdeDataType.Numeric),
        new JdeField("WSACR", "WSACR", JdeDataType.Numeric),
        new JdeField("WSTAXE", "WSTAXE", JdeDataType.Numeric),
        new JdeField("WSM76WPER", "WSM76WPER", JdeDataType.Numeric),
        new JdeField("WSM76ASWH", "WSM76ASWH", JdeDataType.Numeric),
        new JdeField("WSKCO", "WSKCO", JdeDataType.String, 10),
        new JdeField("WSDOC", "WSDOC", JdeDataType.Numeric),
        new JdeField("WSDCT", "WSDCT", JdeDataType.String, 4),
        new JdeField("WSM76GORT", "WSM76GORT", JdeDataType.String, 2),
        new JdeField("WSM76FDAT", "WSM76FDAT", JdeDataType.Numeric),
        new JdeField("WSM76FFLG", "WSM76FFLG", JdeDataType.String, 2),
        new JdeField("WSM76FNUM", "WSM76FNUM", JdeDataType.Numeric),
        new JdeField("WSM76FSTR", "WSM76FSTR", JdeDataType.String, 60),
        new JdeField("WSUSER", "WSUSER", JdeDataType.String, 20),
        new JdeField("WSPID", "WSPID", JdeDataType.String, 20),
        new JdeField("WSJOBN", "WSJOBN", JdeDataType.String, 20),
        new JdeField("WSUPMJ", "WSUPMJ", JdeDataType.Numeric),
        new JdeField("WSUPMT", "WSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M572_0", "Primary Key on WSHDC, WSCKC, WSM76WHTP, WSM76WCON", new[] { "WSHDC", "WSCKC", "WSM76WHTP", "WSM76WCON" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76M572_2", "Index on WSHDC, WSCKC, WSDOC", new[] { "WSHDC", "WSCKC", "WSDOC" })
    };
}
