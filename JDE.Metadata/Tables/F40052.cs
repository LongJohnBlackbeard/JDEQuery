using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40052 - .
/// </summary>
public class F40052 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RVRCTO.
        /// </summary>
        public const string RVRCTO = "RVRCTO";

        /// <summary>
        /// RVTYPS.
        /// </summary>
        public const string RVTYPS = "RVTYPS";

        /// <summary>
        /// RVMMCU.
        /// </summary>
        public const string RVMMCU = "RVMMCU";

        /// <summary>
        /// RVSVGRP.
        /// </summary>
        public const string RVSVGRP = "RVSVGRP";

        /// <summary>
        /// RVVEND.
        /// </summary>
        public const string RVVEND = "RVVEND";

        /// <summary>
        /// RVMCU.
        /// </summary>
        public const string RVMCU = "RVMCU";

        /// <summary>
        /// RVLOCN.
        /// </summary>
        public const string RVLOCN = "RVLOCN";

        /// <summary>
        /// RVMCU2.
        /// </summary>
        public const string RVMCU2 = "RVMCU2";

        /// <summary>
        /// RVLOCNE2.
        /// </summary>
        public const string RVLOCNE2 = "RVLOCNE2";

        /// <summary>
        /// RVMCU3.
        /// </summary>
        public const string RVMCU3 = "RVMCU3";

        /// <summary>
        /// RVLOCNE3.
        /// </summary>
        public const string RVLOCNE3 = "RVLOCNE3";

        /// <summary>
        /// RVMCU4.
        /// </summary>
        public const string RVMCU4 = "RVMCU4";

        /// <summary>
        /// RVLOCNE4.
        /// </summary>
        public const string RVLOCNE4 = "RVLOCNE4";

        /// <summary>
        /// RVVER.
        /// </summary>
        public const string RVVER = "RVVER";

        /// <summary>
        /// RVVERS.
        /// </summary>
        public const string RVVERS = "RVVERS";

        /// <summary>
        /// RVDSHIP.
        /// </summary>
        public const string RVDSHIP = "RVDSHIP";

        /// <summary>
        /// RVRLTD.
        /// </summary>
        public const string RVRLTD = "RVRLTD";

        /// <summary>
        /// RVDFINR.
        /// </summary>
        public const string RVDFINR = "RVDFINR";

        /// <summary>
        /// RVDFINS.
        /// </summary>
        public const string RVDFINS = "RVDFINS";

        /// <summary>
        /// RVDFSNR.
        /// </summary>
        public const string RVDFSNR = "RVDFSNR";

        /// <summary>
        /// RVDFSNS.
        /// </summary>
        public const string RVDFSNS = "RVDFSNS";

        /// <summary>
        /// RVRMAST1.
        /// </summary>
        public const string RVRMAST1 = "RVRMAST1";

        /// <summary>
        /// RVUSER.
        /// </summary>
        public const string RVUSER = "RVUSER";

        /// <summary>
        /// RVPID.
        /// </summary>
        public const string RVPID = "RVPID";

        /// <summary>
        /// RVJOBN.
        /// </summary>
        public const string RVJOBN = "RVJOBN";

        /// <summary>
        /// RVCRTU.
        /// </summary>
        public const string RVCRTU = "RVCRTU";

        /// <summary>
        /// RVUPMJ.
        /// </summary>
        public const string RVUPMJ = "RVUPMJ";

        /// <summary>
        /// RVUPMT.
        /// </summary>
        public const string RVUPMT = "RVUPMT";

        /// <summary>
        /// RVVER1.
        /// </summary>
        public const string RVVER1 = "RVVER1";

        /// <summary>
        /// RVDSH1.
        /// </summary>
        public const string RVDSH1 = "RVDSH1";
    }

    /// <inheritdoc />
    public override string TableName => "F40052";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RVRCTO", "RVRCTO", JdeDataType.String, 4, true, true),
        new JdeField("RVTYPS", "RVTYPS", JdeDataType.String, 2, true, true),
        new JdeField("RVMMCU", "RVMMCU", JdeDataType.String, 24, true, true),
        new JdeField("RVSVGRP", "RVSVGRP", JdeDataType.String, 10, true, true),
        new JdeField("RVVEND", "RVVEND", JdeDataType.Numeric, null, true, true),
        new JdeField("RVMCU", "RVMCU", JdeDataType.String, 24),
        new JdeField("RVLOCN", "RVLOCN", JdeDataType.String, 40),
        new JdeField("RVMCU2", "RVMCU2", JdeDataType.String, 24),
        new JdeField("RVLOCNE2", "RVLOCNE2", JdeDataType.String, 40),
        new JdeField("RVMCU3", "RVMCU3", JdeDataType.String, 24),
        new JdeField("RVLOCNE3", "RVLOCNE3", JdeDataType.String, 40),
        new JdeField("RVMCU4", "RVMCU4", JdeDataType.String, 24),
        new JdeField("RVLOCNE4", "RVLOCNE4", JdeDataType.String, 40),
        new JdeField("RVVER", "RVVER", JdeDataType.String, 20),
        new JdeField("RVVERS", "RVVERS", JdeDataType.String, 20),
        new JdeField("RVDSHIP", "RVDSHIP", JdeDataType.String, 2),
        new JdeField("RVRLTD", "RVRLTD", JdeDataType.Numeric),
        new JdeField("RVDFINR", "RVDFINR", JdeDataType.Numeric),
        new JdeField("RVDFINS", "RVDFINS", JdeDataType.String, 2),
        new JdeField("RVDFSNR", "RVDFSNR", JdeDataType.String, 2),
        new JdeField("RVDFSNS", "RVDFSNS", JdeDataType.String, 2),
        new JdeField("RVRMAST1", "RVRMAST1", JdeDataType.String, 6),
        new JdeField("RVUSER", "RVUSER", JdeDataType.String, 20),
        new JdeField("RVPID", "RVPID", JdeDataType.String, 20),
        new JdeField("RVJOBN", "RVJOBN", JdeDataType.String, 20),
        new JdeField("RVCRTU", "RVCRTU", JdeDataType.String, 20),
        new JdeField("RVUPMJ", "RVUPMJ", JdeDataType.Numeric),
        new JdeField("RVUPMT", "RVUPMT", JdeDataType.Numeric),
        new JdeField("RVVER1", "RVVER1", JdeDataType.String, 20),
        new JdeField("RVDSH1", "RVDSH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40052_0", "Primary Key on RVRCTO, RVTYPS, RVMMCU, RVSVGRP, RVVEND", new[] { "RVRCTO", "RVTYPS", "RVMMCU", "RVSVGRP", "RVVEND" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40052_2", "Index on RVTYPS, RVMMCU, RVSVGRP, RVVEND", new[] { "RVTYPS", "RVMMCU", "RVSVGRP", "RVVEND" })
    };
}
