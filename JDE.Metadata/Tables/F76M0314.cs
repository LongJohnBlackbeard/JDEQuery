using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M0314 - .
/// </summary>
public class F76M0314 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MAPYID.
        /// </summary>
        public const string MAPYID = "MAPYID";

        /// <summary>
        /// MARC5.
        /// </summary>
        public const string MARC5 = "MARC5";

        /// <summary>
        /// MACKNU.
        /// </summary>
        public const string MACKNU = "MACKNU";

        /// <summary>
        /// MAKCO.
        /// </summary>
        public const string MAKCO = "MAKCO";

        /// <summary>
        /// MADOC.
        /// </summary>
        public const string MADOC = "MADOC";

        /// <summary>
        /// MADCT.
        /// </summary>
        public const string MADCT = "MADCT";

        /// <summary>
        /// MAJELN.
        /// </summary>
        public const string MAJELN = "MAJELN";

        /// <summary>
        /// MADGJ.
        /// </summary>
        public const string MADGJ = "MADGJ";

        /// <summary>
        /// MAICU.
        /// </summary>
        public const string MAICU = "MAICU";

        /// <summary>
        /// MAICUT.
        /// </summary>
        public const string MAICUT = "MAICUT";

        /// <summary>
        /// MAOKCO.
        /// </summary>
        public const string MAOKCO = "MAOKCO";

        /// <summary>
        /// MAODCT.
        /// </summary>
        public const string MAODCT = "MAODCT";

        /// <summary>
        /// MAODOC.
        /// </summary>
        public const string MAODOC = "MAODOC";

        /// <summary>
        /// MAOSFX.
        /// </summary>
        public const string MAOSFX = "MAOSFX";

        /// <summary>
        /// MASTAM.
        /// </summary>
        public const string MASTAM = "MASTAM";

        /// <summary>
        /// MACTAM.
        /// </summary>
        public const string MACTAM = "MACTAM";

        /// <summary>
        /// MACO.
        /// </summary>
        public const string MACO = "MACO";

        /// <summary>
        /// MACRCD.
        /// </summary>
        public const string MACRCD = "MACRCD";

        /// <summary>
        /// MABCRC.
        /// </summary>
        public const string MABCRC = "MABCRC";

        /// <summary>
        /// MAGFL1.
        /// </summary>
        public const string MAGFL1 = "MAGFL1";

        /// <summary>
        /// MAUSER.
        /// </summary>
        public const string MAUSER = "MAUSER";

        /// <summary>
        /// MAPID.
        /// </summary>
        public const string MAPID = "MAPID";

        /// <summary>
        /// MAJOBN.
        /// </summary>
        public const string MAJOBN = "MAJOBN";

        /// <summary>
        /// MAUPMJ.
        /// </summary>
        public const string MAUPMJ = "MAUPMJ";

        /// <summary>
        /// MAUPMT.
        /// </summary>
        public const string MAUPMT = "MAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M0314";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MAPYID", "MAPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("MARC5", "MARC5", JdeDataType.Numeric, null, true, true),
        new JdeField("MACKNU", "MACKNU", JdeDataType.String, 50),
        new JdeField("MAKCO", "MAKCO", JdeDataType.String, 10),
        new JdeField("MADOC", "MADOC", JdeDataType.Numeric),
        new JdeField("MADCT", "MADCT", JdeDataType.String, 4),
        new JdeField("MAJELN", "MAJELN", JdeDataType.Numeric),
        new JdeField("MADGJ", "MADGJ", JdeDataType.Numeric),
        new JdeField("MAICU", "MAICU", JdeDataType.Numeric),
        new JdeField("MAICUT", "MAICUT", JdeDataType.String, 4),
        new JdeField("MAOKCO", "MAOKCO", JdeDataType.String, 10),
        new JdeField("MAODCT", "MAODCT", JdeDataType.String, 4),
        new JdeField("MAODOC", "MAODOC", JdeDataType.Numeric),
        new JdeField("MAOSFX", "MAOSFX", JdeDataType.String, 6),
        new JdeField("MASTAM", "MASTAM", JdeDataType.Numeric),
        new JdeField("MACTAM", "MACTAM", JdeDataType.Numeric),
        new JdeField("MACO", "MACO", JdeDataType.String, 10),
        new JdeField("MACRCD", "MACRCD", JdeDataType.String, 6),
        new JdeField("MABCRC", "MABCRC", JdeDataType.String, 6),
        new JdeField("MAGFL1", "MAGFL1", JdeDataType.String, 2),
        new JdeField("MAUSER", "MAUSER", JdeDataType.String, 20),
        new JdeField("MAPID", "MAPID", JdeDataType.String, 20),
        new JdeField("MAJOBN", "MAJOBN", JdeDataType.String, 20),
        new JdeField("MAUPMJ", "MAUPMJ", JdeDataType.Numeric),
        new JdeField("MAUPMT", "MAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M0314_0", "Primary Key on MAPYID, MARC5", new[] { "MAPYID", "MARC5" }, isUnique: true, isPrimaryKey: true)
    };
}
