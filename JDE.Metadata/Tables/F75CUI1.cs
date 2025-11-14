using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75CUI1 - .
/// </summary>
public class F75CUI1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFUSER.
        /// </summary>
        public const string CFUSER = "CFUSER";

        /// <summary>
        /// CFJOBN.
        /// </summary>
        public const string CFJOBN = "CFJOBN";

        /// <summary>
        /// CFJOBS.
        /// </summary>
        public const string CFJOBS = "CFJOBS";

        /// <summary>
        /// CFLNID.
        /// </summary>
        public const string CFLNID = "CFLNID";

        /// <summary>
        /// CFWDS1.
        /// </summary>
        public const string CFWDS1 = "CFWDS1";

        /// <summary>
        /// CFWDSL1.
        /// </summary>
        public const string CFWDSL1 = "CFWDSL1";

        /// <summary>
        /// CFWLN1.
        /// </summary>
        public const string CFWLN1 = "CFWLN1";

        /// <summary>
        /// CFWBA1.
        /// </summary>
        public const string CFWBA1 = "CFWBA1";

        /// <summary>
        /// CFWEA1.
        /// </summary>
        public const string CFWEA1 = "CFWEA1";

        /// <summary>
        /// CFWLY1.
        /// </summary>
        public const string CFWLY1 = "CFWLY1";

        /// <summary>
        /// CFWIL1.
        /// </summary>
        public const string CFWIL1 = "CFWIL1";

        /// <summary>
        /// CFWRS1.
        /// </summary>
        public const string CFWRS1 = "CFWRS1";

        /// <summary>
        /// CFWSPS1.
        /// </summary>
        public const string CFWSPS1 = "CFWSPS1";

        /// <summary>
        /// CFWDS2.
        /// </summary>
        public const string CFWDS2 = "CFWDS2";

        /// <summary>
        /// CFWDSL2.
        /// </summary>
        public const string CFWDSL2 = "CFWDSL2";

        /// <summary>
        /// CFWLN2.
        /// </summary>
        public const string CFWLN2 = "CFWLN2";

        /// <summary>
        /// CFWBA2.
        /// </summary>
        public const string CFWBA2 = "CFWBA2";

        /// <summary>
        /// CFWEA2.
        /// </summary>
        public const string CFWEA2 = "CFWEA2";

        /// <summary>
        /// CFWLY2.
        /// </summary>
        public const string CFWLY2 = "CFWLY2";

        /// <summary>
        /// CFWIL2.
        /// </summary>
        public const string CFWIL2 = "CFWIL2";

        /// <summary>
        /// CFWRS2.
        /// </summary>
        public const string CFWRS2 = "CFWRS2";

        /// <summary>
        /// CFWSPS2.
        /// </summary>
        public const string CFWSPS2 = "CFWSPS2";

        /// <summary>
        /// CFLT.
        /// </summary>
        public const string CFLT = "CFLT";

        /// <summary>
        /// CFCRCX.
        /// </summary>
        public const string CFCRCX = "CFCRCX";
    }

    /// <inheritdoc />
    public override string TableName => "F75CUI1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFUSER", "CFUSER", JdeDataType.String, 20, true, true),
        new JdeField("CFJOBN", "CFJOBN", JdeDataType.String, 20, true, true),
        new JdeField("CFJOBS", "CFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CFLNID", "CFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CFWDS1", "CFWDS1", JdeDataType.String, 120),
        new JdeField("CFWDSL1", "CFWDSL1", JdeDataType.String, 120),
        new JdeField("CFWLN1", "CFWLN1", JdeDataType.String, 20),
        new JdeField("CFWBA1", "CFWBA1", JdeDataType.Numeric),
        new JdeField("CFWEA1", "CFWEA1", JdeDataType.Numeric),
        new JdeField("CFWLY1", "CFWLY1", JdeDataType.Numeric),
        new JdeField("CFWIL1", "CFWIL1", JdeDataType.Numeric),
        new JdeField("CFWRS1", "CFWRS1", JdeDataType.String, 2),
        new JdeField("CFWSPS1", "CFWSPS1", JdeDataType.String, 4),
        new JdeField("CFWDS2", "CFWDS2", JdeDataType.String, 120),
        new JdeField("CFWDSL2", "CFWDSL2", JdeDataType.String, 120),
        new JdeField("CFWLN2", "CFWLN2", JdeDataType.String, 20),
        new JdeField("CFWBA2", "CFWBA2", JdeDataType.Numeric),
        new JdeField("CFWEA2", "CFWEA2", JdeDataType.Numeric),
        new JdeField("CFWLY2", "CFWLY2", JdeDataType.Numeric),
        new JdeField("CFWIL2", "CFWIL2", JdeDataType.Numeric),
        new JdeField("CFWRS2", "CFWRS2", JdeDataType.String, 2),
        new JdeField("CFWSPS2", "CFWSPS2", JdeDataType.String, 4),
        new JdeField("CFLT", "CFLT", JdeDataType.String, 4),
        new JdeField("CFCRCX", "CFCRCX", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75CUI1_0", "Primary Key on CFUSER, CFJOBN, CFJOBS, CFLNID", new[] { "CFUSER", "CFJOBN", "CFJOBS", "CFLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
