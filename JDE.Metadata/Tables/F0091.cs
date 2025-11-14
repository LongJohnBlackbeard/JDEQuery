using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0091 - .
/// </summary>
public class F0091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IFAN8.
        /// </summary>
        public const string IFAN8 = "IFAN8";

        /// <summary>
        /// IFAD1I.
        /// </summary>
        public const string IFAD1I = "IFAD1I";

        /// <summary>
        /// IFAD2I.
        /// </summary>
        public const string IFAD2I = "IFAD2I";

        /// <summary>
        /// IFSEX.
        /// </summary>
        public const string IFSEX = "IFSEX";

        /// <summary>
        /// IFDOB.
        /// </summary>
        public const string IFDOB = "IFDOB";

        /// <summary>
        /// IFIRLN.
        /// </summary>
        public const string IFIRLN = "IFIRLN";

        /// <summary>
        /// IFIRPN.
        /// </summary>
        public const string IFIRPN = "IFIRPN";

        /// <summary>
        /// IFAD3I.
        /// </summary>
        public const string IFAD3I = "IFAD3I";

        /// <summary>
        /// IFAD4I.
        /// </summary>
        public const string IFAD4I = "IFAD4I";

        /// <summary>
        /// IFIRIF.
        /// </summary>
        public const string IFIRIF = "IFIRIF";

        /// <summary>
        /// IFIRPF.
        /// </summary>
        public const string IFIRPF = "IFIRPF";

        /// <summary>
        /// IFIRGF.
        /// </summary>
        public const string IFIRGF = "IFIRGF";

        /// <summary>
        /// IFIRC1.
        /// </summary>
        public const string IFIRC1 = "IFIRC1";

        /// <summary>
        /// IFFFU1.
        /// </summary>
        public const string IFFFU1 = "IFFFU1";

        /// <summary>
        /// IFVNXT.
        /// </summary>
        public const string IFVNXT = "IFVNXT";

        /// <summary>
        /// IFUSER.
        /// </summary>
        public const string IFUSER = "IFUSER";

        /// <summary>
        /// IFPID.
        /// </summary>
        public const string IFPID = "IFPID";

        /// <summary>
        /// IFJOBN.
        /// </summary>
        public const string IFJOBN = "IFJOBN";

        /// <summary>
        /// IFUPMJ.
        /// </summary>
        public const string IFUPMJ = "IFUPMJ";

        /// <summary>
        /// IFUPMT.
        /// </summary>
        public const string IFUPMT = "IFUPMT";

        /// <summary>
        /// IFY74TAN8.
        /// </summary>
        public const string IFY74TAN8 = "IFY74TAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F0091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IFAN8", "IFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("IFAD1I", "IFAD1I", JdeDataType.String, 80),
        new JdeField("IFAD2I", "IFAD2I", JdeDataType.String, 80),
        new JdeField("IFSEX", "IFSEX", JdeDataType.String, 2),
        new JdeField("IFDOB", "IFDOB", JdeDataType.Numeric),
        new JdeField("IFIRLN", "IFIRLN", JdeDataType.String, 60),
        new JdeField("IFIRPN", "IFIRPN", JdeDataType.String, 6),
        new JdeField("IFAD3I", "IFAD3I", JdeDataType.String, 80),
        new JdeField("IFAD4I", "IFAD4I", JdeDataType.String, 80),
        new JdeField("IFIRIF", "IFIRIF", JdeDataType.String, 6),
        new JdeField("IFIRPF", "IFIRPF", JdeDataType.String, 2),
        new JdeField("IFIRGF", "IFIRGF", JdeDataType.String, 4),
        new JdeField("IFIRC1", "IFIRC1", JdeDataType.String, 4),
        new JdeField("IFFFU1", "IFFFU1", JdeDataType.String, 2),
        new JdeField("IFVNXT", "IFVNXT", JdeDataType.String, 20),
        new JdeField("IFUSER", "IFUSER", JdeDataType.String, 20),
        new JdeField("IFPID", "IFPID", JdeDataType.String, 20),
        new JdeField("IFJOBN", "IFJOBN", JdeDataType.String, 20),
        new JdeField("IFUPMJ", "IFUPMJ", JdeDataType.Numeric),
        new JdeField("IFUPMT", "IFUPMT", JdeDataType.Numeric),
        new JdeField("IFY74TAN8", "IFY74TAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0091_0", "Primary Key on IFAN8", new[] { "IFAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
