using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0115Z1 - .
/// </summary>
public class F0115Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIEDUS.
        /// </summary>
        public const string PIEDUS = "PIEDUS";

        /// <summary>
        /// PIEDBT.
        /// </summary>
        public const string PIEDBT = "PIEDBT";

        /// <summary>
        /// PIEDTN.
        /// </summary>
        public const string PIEDTN = "PIEDTN";

        /// <summary>
        /// PIEDLN.
        /// </summary>
        public const string PIEDLN = "PIEDLN";

        /// <summary>
        /// PIEDTL.
        /// </summary>
        public const string PIEDTL = "PIEDTL";

        /// <summary>
        /// PIEDCT.
        /// </summary>
        public const string PIEDCT = "PIEDCT";

        /// <summary>
        /// PITYTN.
        /// </summary>
        public const string PITYTN = "PITYTN";

        /// <summary>
        /// PIEDFT.
        /// </summary>
        public const string PIEDFT = "PIEDFT";

        /// <summary>
        /// PIEDDT.
        /// </summary>
        public const string PIEDDT = "PIEDDT";

        /// <summary>
        /// PIDRIN.
        /// </summary>
        public const string PIDRIN = "PIDRIN";

        /// <summary>
        /// PIEDDL.
        /// </summary>
        public const string PIEDDL = "PIEDDL";

        /// <summary>
        /// PIEDSP.
        /// </summary>
        public const string PIEDSP = "PIEDSP";

        /// <summary>
        /// PIPNID.
        /// </summary>
        public const string PIPNID = "PIPNID";

        /// <summary>
        /// PITNAC.
        /// </summary>
        public const string PITNAC = "PITNAC";

        /// <summary>
        /// PIAN8.
        /// </summary>
        public const string PIAN8 = "PIAN8";

        /// <summary>
        /// PIIDLN.
        /// </summary>
        public const string PIIDLN = "PIIDLN";

        /// <summary>
        /// PIRCK7.
        /// </summary>
        public const string PIRCK7 = "PIRCK7";

        /// <summary>
        /// PICNLN.
        /// </summary>
        public const string PICNLN = "PICNLN";

        /// <summary>
        /// PIPHTP.
        /// </summary>
        public const string PIPHTP = "PIPHTP";

        /// <summary>
        /// PIAR1.
        /// </summary>
        public const string PIAR1 = "PIAR1";

        /// <summary>
        /// PIPH1.
        /// </summary>
        public const string PIPH1 = "PIPH1";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIUPMT.
        /// </summary>
        public const string PIUPMT = "PIUPMT";

        /// <summary>
        /// PICFNO1.
        /// </summary>
        public const string PICFNO1 = "PICFNO1";

        /// <summary>
        /// PIGEN1.
        /// </summary>
        public const string PIGEN1 = "PIGEN1";

        /// <summary>
        /// PIFALGE.
        /// </summary>
        public const string PIFALGE = "PIFALGE";
    }

    /// <inheritdoc />
    public override string TableName => "F0115Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIEDUS", "PIEDUS", JdeDataType.String, 20, true, true),
        new JdeField("PIEDBT", "PIEDBT", JdeDataType.String, 30, true, true),
        new JdeField("PIEDTN", "PIEDTN", JdeDataType.String, 44, true, true),
        new JdeField("PIEDLN", "PIEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PIEDTL", "PIEDTL", JdeDataType.String, 40, true, true),
        new JdeField("PIEDCT", "PIEDCT", JdeDataType.String, 4),
        new JdeField("PITYTN", "PITYTN", JdeDataType.String, 16),
        new JdeField("PIEDFT", "PIEDFT", JdeDataType.String, 20),
        new JdeField("PIEDDT", "PIEDDT", JdeDataType.Numeric),
        new JdeField("PIDRIN", "PIDRIN", JdeDataType.String, 2),
        new JdeField("PIEDDL", "PIEDDL", JdeDataType.Numeric),
        new JdeField("PIEDSP", "PIEDSP", JdeDataType.String, 2),
        new JdeField("PIPNID", "PIPNID", JdeDataType.String, 30),
        new JdeField("PITNAC", "PITNAC", JdeDataType.String, 4),
        new JdeField("PIAN8", "PIAN8", JdeDataType.Numeric),
        new JdeField("PIIDLN", "PIIDLN", JdeDataType.Numeric),
        new JdeField("PIRCK7", "PIRCK7", JdeDataType.Numeric),
        new JdeField("PICNLN", "PICNLN", JdeDataType.Numeric),
        new JdeField("PIPHTP", "PIPHTP", JdeDataType.String, 8),
        new JdeField("PIAR1", "PIAR1", JdeDataType.String, 12),
        new JdeField("PIPH1", "PIPH1", JdeDataType.String, 40),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIUPMT", "PIUPMT", JdeDataType.Numeric),
        new JdeField("PICFNO1", "PICFNO1", JdeDataType.Numeric),
        new JdeField("PIGEN1", "PIGEN1", JdeDataType.String, 20),
        new JdeField("PIFALGE", "PIFALGE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0115Z1_0", "Primary Key on PIEDUS, PIEDBT, PIEDTN, PIEDLN, PIEDTL", new[] { "PIEDUS", "PIEDBT", "PIEDTN", "PIEDLN", "PIEDTL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0115Z1_2", "Index on PIEDUS, PIEDBT", new[] { "PIEDUS", "PIEDBT" })
    };
}
