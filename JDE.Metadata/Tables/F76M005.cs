using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M005 - .
/// </summary>
public class F76M005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GCCO.
        /// </summary>
        public const string GCCO = "GCCO";

        /// <summary>
        /// GCM76WHTP.
        /// </summary>
        public const string GCM76WHTP = "GCM76WHTP";

        /// <summary>
        /// GCDCT.
        /// </summary>
        public const string GCDCT = "GCDCT";

        /// <summary>
        /// GCITEM.
        /// </summary>
        public const string GCITEM = "GCITEM";

        /// <summary>
        /// GCM76FSTR.
        /// </summary>
        public const string GCM76FSTR = "GCM76FSTR";

        /// <summary>
        /// GCM76FNUM.
        /// </summary>
        public const string GCM76FNUM = "GCM76FNUM";

        /// <summary>
        /// GCM76FFLG.
        /// </summary>
        public const string GCM76FFLG = "GCM76FFLG";

        /// <summary>
        /// GCM76FDAT.
        /// </summary>
        public const string GCM76FDAT = "GCM76FDAT";

        /// <summary>
        /// GCUSER.
        /// </summary>
        public const string GCUSER = "GCUSER";

        /// <summary>
        /// GCPID.
        /// </summary>
        public const string GCPID = "GCPID";

        /// <summary>
        /// GCJOBN.
        /// </summary>
        public const string GCJOBN = "GCJOBN";

        /// <summary>
        /// GCUPMJ.
        /// </summary>
        public const string GCUPMJ = "GCUPMJ";

        /// <summary>
        /// GCUPMT.
        /// </summary>
        public const string GCUPMT = "GCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GCCO", "GCCO", JdeDataType.String, 10, true, true),
        new JdeField("GCM76WHTP", "GCM76WHTP", JdeDataType.String, 2, true, true),
        new JdeField("GCDCT", "GCDCT", JdeDataType.String, 4),
        new JdeField("GCITEM", "GCITEM", JdeDataType.String, 12),
        new JdeField("GCM76FSTR", "GCM76FSTR", JdeDataType.String, 60),
        new JdeField("GCM76FNUM", "GCM76FNUM", JdeDataType.Numeric),
        new JdeField("GCM76FFLG", "GCM76FFLG", JdeDataType.String, 2),
        new JdeField("GCM76FDAT", "GCM76FDAT", JdeDataType.Numeric),
        new JdeField("GCUSER", "GCUSER", JdeDataType.String, 20),
        new JdeField("GCPID", "GCPID", JdeDataType.String, 20),
        new JdeField("GCJOBN", "GCJOBN", JdeDataType.String, 20),
        new JdeField("GCUPMJ", "GCUPMJ", JdeDataType.Numeric),
        new JdeField("GCUPMT", "GCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M005_0", "Primary Key on GCCO, GCM76WHTP", new[] { "GCCO", "GCM76WHTP" }, isUnique: true, isPrimaryKey: true)
    };
}
