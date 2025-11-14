using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AGX07 - .
/// </summary>
public class FY5AGX07 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIRLS.
        /// </summary>
        public const string DIRLS = "DIRLS";

        /// <summary>
        /// DIY5AGENVN.
        /// </summary>
        public const string DIY5AGENVN = "DIY5AGENVN";

        /// <summary>
        /// DIOBNM.
        /// </summary>
        public const string DIOBNM = "DIOBNM";

        /// <summary>
        /// DIFUNO.
        /// </summary>
        public const string DIFUNO = "DIFUNO";

        /// <summary>
        /// DIOBJP.
        /// </summary>
        public const string DIOBJP = "DIOBJP";

        /// <summary>
        /// DIATRP.
        /// </summary>
        public const string DIATRP = "DIATRP";

        /// <summary>
        /// DIFDNM.
        /// </summary>
        public const string DIFDNM = "DIFDNM";

        /// <summary>
        /// DIY5AGPNM.
        /// </summary>
        public const string DIY5AGPNM = "DIY5AGPNM";

        /// <summary>
        /// DIATRS.
        /// </summary>
        public const string DIATRS = "DIATRS";

        /// <summary>
        /// DIUPD.
        /// </summary>
        public const string DIUPD = "DIUPD";

        /// <summary>
        /// DIDDID.
        /// </summary>
        public const string DIDDID = "DIDDID";

        /// <summary>
        /// DIAPPLID.
        /// </summary>
        public const string DIAPPLID = "DIAPPLID";

        /// <summary>
        /// DIKYSQ.
        /// </summary>
        public const string DIKYSQ = "DIKYSQ";

        /// <summary>
        /// DIY5AGRFLG.
        /// </summary>
        public const string DIY5AGRFLG = "DIY5AGRFLG";

        /// <summary>
        /// DIY5AGOBJC.
        /// </summary>
        public const string DIY5AGOBJC = "DIY5AGOBJC";

        /// <summary>
        /// DIY5AGFRMC.
        /// </summary>
        public const string DIY5AGFRMC = "DIY5AGFRMC";

        /// <summary>
        /// DIY5AGVNMC.
        /// </summary>
        public const string DIY5AGVNMC = "DIY5AGVNMC";

        /// <summary>
        /// DIY5AGPATH.
        /// </summary>
        public const string DIY5AGPATH = "DIY5AGPATH";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AGX07";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIRLS", "DIRLS", JdeDataType.String, 20),
        new JdeField("DIY5AGENVN", "DIY5AGENVN", JdeDataType.String, 20, true, true),
        new JdeField("DIOBNM", "DIOBNM", JdeDataType.String, 20, true, true),
        new JdeField("DIFUNO", "DIFUNO", JdeDataType.String, 8),
        new JdeField("DIOBJP", "DIOBJP", JdeDataType.String, 20, true, true),
        new JdeField("DIATRP", "DIATRP", JdeDataType.String, 12, true, true),
        new JdeField("DIFDNM", "DIFDNM", JdeDataType.String, 60, true, true),
        new JdeField("DIY5AGPNM", "DIY5AGPNM", JdeDataType.String, 60, true, true),
        new JdeField("DIATRS", "DIATRS", JdeDataType.String, 12, true, true),
        new JdeField("DIUPD", "DIUPD", JdeDataType.String, 2),
        new JdeField("DIDDID", "DIDDID", JdeDataType.Numeric, null, true, true),
        new JdeField("DIAPPLID", "DIAPPLID", JdeDataType.Numeric, null, true, true),
        new JdeField("DIKYSQ", "DIKYSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DIY5AGRFLG", "DIY5AGRFLG", JdeDataType.String, 2),
        new JdeField("DIY5AGOBJC", "DIY5AGOBJC", JdeDataType.String, 20),
        new JdeField("DIY5AGFRMC", "DIY5AGFRMC", JdeDataType.String, 20),
        new JdeField("DIY5AGVNMC", "DIY5AGVNMC", JdeDataType.String, 20),
        new JdeField("DIY5AGPATH", "DIY5AGPATH", JdeDataType.String, 240),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AGX07_0", "Primary Key on DIY5AGENVN, DIOBNM, DIOBJP, DIATRP, DIFDNM, DIY5AGPNM, DIATRS, DIDDID, DIAPPLID, DIKYSQ", new[] { "DIY5AGENVN", "DIOBNM", "DIOBJP", "DIATRP", "DIFDNM", "DIY5AGPNM", "DIATRS", "DIDDID", "DIAPPLID", "DIKYSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
