using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M413A - .
/// </summary>
public class F76M413A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCPYID.
        /// </summary>
        public const string WCPYID = "WCPYID";

        /// <summary>
        /// WCM76LCON.
        /// </summary>
        public const string WCM76LCON = "WCM76LCON";

        /// <summary>
        /// WCM76WHCN.
        /// </summary>
        public const string WCM76WHCN = "WCM76WHCN";

        /// <summary>
        /// WCM76FFLG.
        /// </summary>
        public const string WCM76FFLG = "WCM76FFLG";

        /// <summary>
        /// WCM76FNUM.
        /// </summary>
        public const string WCM76FNUM = "WCM76FNUM";

        /// <summary>
        /// WCM76FSTR.
        /// </summary>
        public const string WCM76FSTR = "WCM76FSTR";

        /// <summary>
        /// WCM76FDAT.
        /// </summary>
        public const string WCM76FDAT = "WCM76FDAT";

        /// <summary>
        /// WCJOBN.
        /// </summary>
        public const string WCJOBN = "WCJOBN";

        /// <summary>
        /// WCPID.
        /// </summary>
        public const string WCPID = "WCPID";

        /// <summary>
        /// WCUPMJ.
        /// </summary>
        public const string WCUPMJ = "WCUPMJ";

        /// <summary>
        /// WCUPMT.
        /// </summary>
        public const string WCUPMT = "WCUPMT";

        /// <summary>
        /// WCUSER.
        /// </summary>
        public const string WCUSER = "WCUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F76M413A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCPYID", "WCPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("WCM76LCON", "WCM76LCON", JdeDataType.String, 6, true, true),
        new JdeField("WCM76WHCN", "WCM76WHCN", JdeDataType.Numeric),
        new JdeField("WCM76FFLG", "WCM76FFLG", JdeDataType.String, 2),
        new JdeField("WCM76FNUM", "WCM76FNUM", JdeDataType.Numeric),
        new JdeField("WCM76FSTR", "WCM76FSTR", JdeDataType.String, 60),
        new JdeField("WCM76FDAT", "WCM76FDAT", JdeDataType.Numeric),
        new JdeField("WCJOBN", "WCJOBN", JdeDataType.String, 20),
        new JdeField("WCPID", "WCPID", JdeDataType.String, 20),
        new JdeField("WCUPMJ", "WCUPMJ", JdeDataType.Numeric),
        new JdeField("WCUPMT", "WCUPMT", JdeDataType.Numeric),
        new JdeField("WCUSER", "WCUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M413A_0", "Primary Key on WCPYID, WCM76LCON", new[] { "WCPYID", "WCM76LCON" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76M413A_2", "Index on WCM76WHCN", new[] { "WCM76WHCN" })
    };
}
